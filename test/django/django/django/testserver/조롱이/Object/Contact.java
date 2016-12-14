package insurance.manager.appplepi.com.insurancemg.Object;

/**
 * Created by Sunrin on 2016-03-14.
 */
public class Contact {
    long photoid;
    String name;
    String phonenum;

    public String getName() {
        return name;
    }

    public String getPhonenum() {
        return phonenum;
    }

    public long getPhotoid() {
        return photoid;
    }

    public void setPhotoid(long photoid) {
        this.photoid = photoid;
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setPhonenum(String phonenum) {
        this.phonenum = phonenum;
    }
}
