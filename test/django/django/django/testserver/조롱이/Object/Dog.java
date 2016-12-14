package insurance.manager.appplepi.com.insurancemg.Object;

import io.realm.RealmObject;
import io.realm.annotations.Required;

/**
 * Created by Sunrin on 2016-04-20.
 */
public class Dog extends RealmObject {
    @Required // Name cannot be null
    private String name;
    private int age;

    public void setName(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }
    // ... Generated getters and setters ...
}
