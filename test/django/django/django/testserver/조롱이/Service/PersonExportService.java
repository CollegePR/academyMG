package insurance.manager.appplepi.com.insurancemg.Service;

import java.util.List;

import insurance.manager.appplepi.com.insurancemg.Object.InsureInfo;
import retrofit.Callback;
import retrofit.http.POST;
public interface PersonExportService {
    @POST("/")
    void getPersonList(Callback<List<InsureInfo>> callback);

    /*
    1.계약자, 피보험자, 관리자 성명, 주민번호, 연락처, 주소
2.차량번호
3.보험기간,분납날짜
4.보험료,분납보험료
5.가상계좌

@Field("contractor")String contractor,
                       @Field("insured_person")String insuredPerson,
                       @Field("admin")String admin,
                       @Field("s_s_number")String SSNumber ,
                       @Field("phone_number")String phoneNumber,
                       @Field("adress")String address ,
                       @Field("car_number")String carNumber ,
                       @Field("insurance_period")String insurancePeriod,
                       @Field("installment_date")String InstallmentDate,
                       @Field("premium")long premium,
                       @Field("installment_premium")long installmentPremium,
                       @Field("virtual_account")String virtualAccount,
     */
}
