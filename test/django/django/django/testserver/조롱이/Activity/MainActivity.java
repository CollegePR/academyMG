package insurance.manager.appplepi.com.insurancemg.Activity;

import android.content.Intent;
import android.database.Cursor;
import android.net.Uri;
import android.os.Bundle;
import android.provider.ContactsContract;
import android.support.design.widget.FloatingActionButton;
import android.support.design.widget.Snackbar;
import android.support.v7.widget.GridLayoutManager;
import android.support.v7.widget.RecyclerView;
import android.util.Log;
import android.view.View;
import android.support.design.widget.NavigationView;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.List;

import insurance.manager.appplepi.com.insurancemg.Adapter.MyAdapter;
import insurance.manager.appplepi.com.insurancemg.Adapter.NavAdapter;
import insurance.manager.appplepi.com.insurancemg.Object.Contact;
import insurance.manager.appplepi.com.insurancemg.Object.InsureInfo;
import insurance.manager.appplepi.com.insurancemg.Object.MyData;
import insurance.manager.appplepi.com.insurancemg.R;
import insurance.manager.appplepi.com.insurancemg.Realm.RealmInsureInfo;
import insurance.manager.appplepi.com.insurancemg.Service.PersonExportService;
import insurance.manager.appplepi.com.insurancemg.Util.RetrofitUtil;
import retrofit.Callback;
import retrofit.RetrofitError;
import retrofit.client.Response;

public class MainActivity extends AppCompatActivity
        implements NavigationView.OnNavigationItemSelectedListener {
    private RecyclerView mRecyclerView;
    private RecyclerView.Adapter mAdapter;
    private RecyclerView.LayoutManager mLayoutManager;
    private ArrayList<InsureInfo> myDataset;
    private NavAdapter m_Adapter;
    private ListView m_ListView;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        Toolbar toolbar = (Toolbar) findViewById(R.id.toolbar);
        setSupportActionBar(toolbar);

        m_Adapter = new NavAdapter();

        // Xml에서 추가한 ListView 연결
        m_ListView = (ListView) findViewById(R.id.list_view_inside_nav);

        m_ListView.setAdapter(m_Adapter);

        // ListView에 아이템 추가
        m_Adapter.addLine("필터");
        m_Adapter.add("계약자");
        m_Adapter.add("차량번호");
        m_Adapter.add("피보험자");
        m_Adapter.addLine("정렬");
        m_Adapter.add("분납날짜순");
        m_Adapter.add("계약자 이름순");
        m_Adapter.add("생년월일순");
        m_Adapter.add("보험료순");

        FloatingActionButton fab = (FloatingActionButton) findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                /*Snackbar.make(view, "Replace with your own action", Snackbar.LENGTH_LONG)
                        .setAction("Action", null).show();*/
                Intent addActivity=new Intent(getApplicationContext(),AddActivity.class);
                startActivity(addActivity);
            }
        });

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        ActionBarDrawerToggle toggle = new ActionBarDrawerToggle(
                this, drawer, toolbar, R.string.navigation_drawer_open, R.string.navigation_drawer_close);
        drawer.setDrawerListener(toggle);
        toggle.syncState();
        mRecyclerView = (RecyclerView) findViewById(R.id.my_recycler_view);

        // use this setting to improve performance if you know that changes
        // in content do not change the layout size of the RecyclerView
        mRecyclerView.setHasFixedSize(true);

        // use a linear layout manager
        mLayoutManager = new GridLayoutManager(this,2);
        mRecyclerView.setLayoutManager(mLayoutManager);
        myDataset = new ArrayList<>();
        mAdapter = new MyAdapter(myDataset);
        mRecyclerView.setAdapter(mAdapter);

        PersonExportService service = RetrofitUtil.getAdapter().create(PersonExportService.class);
        service.getPersonList(new Callback<List<InsureInfo>>() {
            @Override
            public void success(List<InsureInfo> datas, Response response) {
                for (InsureInfo data : datas) {
                    RealmInsureInfo realmInsureInfo=new RealmInsureInfo(getApplicationContext());
                    Log.d("sibal",data.getContractor()+" "+data.getPhoneNumber()+" "+data.getAdmin());

                    myDataset.add(data);
                    m_Adapter.notifyDataSetChanged();
                    realmInsureInfo.setData(data);
                  //  Snackbar.make(,data.getContractor(), Snackbar.LENGTH_LONG).setAction("Action", null).show();
                }
            }

            @Override
            public void failure(RetrofitError error) {
                Log.d("sibal",error.toString());
            }
        });

        NavigationView navigationView = (NavigationView) findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);
        ArrayList<Contact> temp=getContactList();
//        Toast.makeText(getApplicationContext(), temp.get(0).getName(),Toast.LENGTH_LONG).show();



        // specify an adapter (see also next example)



    }
    private ArrayList<Contact> getContactList() {

        Uri uri = ContactsContract.CommonDataKinds.Phone.CONTENT_URI;

        String[] projection = new String[] {
                ContactsContract.CommonDataKinds.Phone.CONTACT_ID, // 연락처 ID -> 사진 정보 가져오는데 사용
                ContactsContract.CommonDataKinds.Phone.NUMBER,        // 연락처
                ContactsContract.CommonDataKinds.Phone.DISPLAY_NAME }; // 연락처 이름.

        String[] selectionArgs = null;

        String sortOrder = ContactsContract.CommonDataKinds.Phone.DISPLAY_NAME
                + " COLLATE LOCALIZED ASC";

        Cursor contactCursor = managedQuery(uri, projection, null,
                selectionArgs, sortOrder);

        ArrayList<Contact> contactlist = new ArrayList<Contact>();

        if (contactCursor.moveToFirst()) {
            do {
                String phonenumber = contactCursor.getString(1).replaceAll("-",
                        "");
                if (phonenumber.length() == 10) {
                    phonenumber = phonenumber.substring(0, 3) + "-"
                            + phonenumber.substring(3, 6) + "-"
                            + phonenumber.substring(6);
                } else if (phonenumber.length() > 8) {
                    phonenumber = phonenumber.substring(0, 3) + "-"
                            + phonenumber.substring(3, 7) + "-"
                            + phonenumber.substring(7);
                }
                Contact acontact = new Contact();
                acontact.setPhotoid(contactCursor.getLong(0));
                acontact.setPhonenum(phonenumber);
                acontact.setName(contactCursor.getString(2));

                contactlist.add(acontact);
            } while (contactCursor.moveToNext());
        }

        return contactlist;

    }
    @Override
    public void onBackPressed() {
        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        if (drawer.isDrawerOpen(GravityCompat.START)) {
            drawer.closeDrawer(GravityCompat.START);
        } else {
            super.onBackPressed();
        }
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.main, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

    @SuppressWarnings("StatementWithEmptyBody")
    @Override
    public boolean onNavigationItemSelected(MenuItem item) {
        // Handle navigation view item clicks here.
        int id = item.getItemId();

       /* if (id == R.id.nav_camara) {
            // Handle the camera action
        } else if (id == R.id.nav_gallery) {

        } else if (id == R.id.nav_slideshow) {

        } else if (id == R.id.nav_manage) {

        } else if (id == R.id.nav_share) {

        } else if (id == R.id.nav_send) {

        }*/

        DrawerLayout drawer = (DrawerLayout) findViewById(R.id.drawer_layout);
        drawer.closeDrawer(GravityCompat.START);
        return true;
    }

}
