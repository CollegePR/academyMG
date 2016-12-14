package insurance.manager.appplepi.com.insurancemg.Realm;

import android.content.Context;
import android.util.Log;

import io.realm.Realm;
import io.realm.RealmConfiguration;

/**
 * Created by Sunrin on 2016-04-20.
 */
public class RealmInsureInfo {
    Realm realm;
    public RealmInsureInfo() {

    }
    public RealmInsureInfo(Context context) {
        // Use them like regular java objects

        // Create a RealmConfiguration which is to locate Realm file in package's "files" directory.
        RealmConfiguration realmConfig = new RealmConfiguration.Builder(context).build();
        // Get a Realm instance for this thread
        realm = Realm.getInstance(realmConfig);

        // Query Realm for all insureInfos less than 2 years old
    //    final RealmResults<insureInfo> puppies = realm.where(InsureInfo.class).lessThan("age", 2).findAll();
   //     puppies.size(); // => 0 because no insureInfos have been added to the Realm yet

// Persist your data easily


// Queries are updated in real time
       // puppies.size(); // => 1
// Query and update the result asynchronously in another thread

    }
    public void setData(insurance.manager.appplepi.com.insurancemg.Object.InsureInfo insureInfo){
        realm.beginTransaction();
        realm.copyToRealm(new insurance.manager.appplepi.com.insurancemg.Realm.InsureInfo(insureInfo));
        realm.commitTransaction();
    }
    public insurance.manager.appplepi.com.insurancemg.Object.InsureInfo getDataByKey(final String key, final String value){
        InsureInfo insureInfo = realm.where(InsureInfo.class).equalTo(key, value).findFirst();
    /*
        realm.executeTransactionAsync(new Realm.Transaction() {
            @Override
            public void execute(Realm realm) {
            }
        },new Realm.Transaction.OnError(){

            @Override
            public void onError(Throwable error) {

            }
        });
        */
        return new insurance.manager.appplepi.com.insurancemg.Object.InsureInfo(insureInfo);
    }
}
