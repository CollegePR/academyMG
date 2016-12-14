package insurance.manager.appplepi.com.insurancemg.Util;

import retrofit.RestAdapter;

public class RetrofitUtil {

    private static RestAdapter adapter;

    public static RestAdapter getAdapter() {
        if (null == adapter) {
            adapter = new RestAdapter.Builder()
                    .setEndpoint("http://donquix.iptime.org:8000")
                    .build();
        }

        return adapter;
    }
}
