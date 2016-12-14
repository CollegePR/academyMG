package insurance.manager.appplepi.com.insurancemg.Object;


/**
 * Created by Sunrin on 2016-03-14.
 */
public class InsureInfo{
    String contractor;
    String insuredPerson;
    String admin;
    String SSNumber ;
    String phoneNumber;
    String address ;
    String carNumber ;
    String insurancePeriod;
    String installmentDate;
    long premium;
    long installmentPremium;

    public void setContractor(String contractor) {
        this.contractor = contractor;
    }

    public void setInsuredPerson(String insuredPerson) {
        this.insuredPerson = insuredPerson;
    }

    public void setAdmin(String admin) {
        this.admin = admin;
    }

    public void setSSNumber(String SSNumber) {
        this.SSNumber = SSNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public void setCarNumber(String carNumber) {
        this.carNumber = carNumber;
    }

    public void setInsurancePeriod(String insurancePeriod) {
        this.insurancePeriod = insurancePeriod;
    }

    public void setInstallmentDate(String installmentDate) {
        this.installmentDate = installmentDate;
    }

    public String getInstallmentDate() {

        return installmentDate;
    }

    public void setPremium(long premium) {
        this.premium = premium;
    }

    public void setInstallmentPremium(long installmentPremium) {
        this.installmentPremium = installmentPremium;
    }

    public void setVirtualAccount(String virtualAccount) {
        this.virtualAccount = virtualAccount;
    }

    public String getContractor() {

        return contractor;
    }

    public String getInsuredPerson() {
        return insuredPerson;
    }

    public String getAdmin() {
        return admin;
    }

    public String getSSNumber() {
        return SSNumber;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public String getAddress() {
        return address;
    }

    public String getCarNumber() {
        return carNumber;
    }

    public String getInsurancePeriod() {
        return insurancePeriod;
    }


    public long getPremium() {
        return premium;
    }

    public long getInstallmentPremium() {
        return installmentPremium;
    }

    public String getVirtualAccount() {
        return virtualAccount;
    }

    String virtualAccount;
    public InsureInfo(insurance.manager.appplepi.com.insurancemg.Realm.InsureInfo insureInfo) {
        contractor = insureInfo.getContractor();
        insuredPerson = insureInfo.getInsuredPerson();
        admin = insureInfo.getAdmin();
        SSNumber = insureInfo.getSSNumber();
        phoneNumber = insureInfo.getPhoneNumber();
        address = insureInfo.getAddress();
        carNumber = insureInfo.getCarNumber();
        insurancePeriod = insureInfo.getInsurancePeriod();
        installmentDate = insureInfo.getInstallmentDate();
        premium = insureInfo.getPremium();
        installmentPremium = insureInfo.getInstallmentPremium();
    }
}
