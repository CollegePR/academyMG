package insurance.manager.appplepi.com.insurancemg.Object;

import io.realm.RealmList;
import io.realm.RealmObject;
import io.realm.annotations.Required;

/**
 * Created by Sunrin on 2016-03-21.
 */
public class Person extends RealmObject {
    @Required // Name is not nullable
    private String name;
    private String imageUrl; // imageUrl is an optional field

    public void setName(String name) {
        this.name = name;
    }

    public void setImageUrl(String imageUrl) {
        this.imageUrl = imageUrl;
    }

    public void setDogs(RealmList<Dog> dogs) {
        this.dogs = dogs;
    }

    public RealmList<Dog> getDogs() {
        return dogs;
    }

    public String getName() {
        return name;
    }

    public String getImageUrl() {
        return imageUrl;
    }

    private RealmList<Dog> dogs; // A person has many dogs (a relationship)

    // ... Generated getters and setters ...
}
