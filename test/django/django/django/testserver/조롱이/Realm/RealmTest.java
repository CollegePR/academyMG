package insurance.manager.appplepi.com.insurancemg.Realm;

import android.content.Context;
import android.util.Log;

import insurance.manager.appplepi.com.insurancemg.Object.Dog;
import io.realm.Realm;
import io.realm.RealmAsyncTask;
import io.realm.RealmConfiguration;
import io.realm.RealmList;
import io.realm.RealmObject;
import io.realm.RealmResults;
import io.realm.annotations.Required;

/**
 * Created by Sunrin on 2016-04-20.
 */
public class RealmTest {
    RealmTest(Context context) {
        // Use them like regular java objects
        final Dog dog = new Dog();
        dog.setName("Rex");
        dog.setAge(1);
        Log.v("sibal", "Name of the dog: " + dog.getName());

        // Create a RealmConfiguration which is to locate Realm file in package's "files" directory.
        RealmConfiguration realmConfig = new RealmConfiguration.Builder(context).build();
        // Get a Realm instance for this thread
        Realm realm = Realm.getInstance(realmConfig);

        // Query Realm for all dogs less than 2 years old
        final RealmResults<Dog> puppies = realm.where(Dog.class).lessThan("age", 2).findAll();
        puppies.size(); // => 0 because no dogs have been added to the Realm yet

// Persist your data easily
        realm.beginTransaction();
        realm.copyToRealm(dog);
        realm.commitTransaction();

// Queries are updated in real time
        puppies.size(); // => 1

// Query and update the result asynchronously in another thread
        realm.executeTransactionAsync(new Realm.Transaction() {
            @Override
            public void execute(Realm realm) {
                // begin & end transcation calls are done for you
                Dog theDog = realm.where(Dog.class).equalTo("age", 1).findFirst();
                theDog.setAge(3);
            }
        }, new Realm.Transaction.OnSuccess() {
            @Override
            public void onSuccess() {
                // Original Queries and Realm objects are automatically updated.
                puppies.size(); // => 0 because there are no more puppies (less than 2 years old)
                dog.getAge();   // => 3 the dogs age is updated
            }
        },new Realm.Transaction.OnError(){

            @Override
            public void onError(Throwable error) {

            }
        });
    }
}
