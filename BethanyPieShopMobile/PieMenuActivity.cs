using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.Widget;
using BethanyPieShopMobile.Adapters;

namespace BethanyPieShopMobile
{
    [Activity(Label = "PieMenuActivity" )]
    public class PieMenuActivity : Activity
    {
        private RecyclerView _pieRecyclerView;
        private RecyclerView.LayoutManager _pieLayoutManager;
        private PieAdapter _pieAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_menu);
            // Create your application here
            _pieRecyclerView = FindViewById<RecyclerView>(Resource.Id.pieRecyclerView);

            // you need
            // 1. layoutManager
            // 2. view Holder
            // 3. Pie Adapter
            _pieLayoutManager = new LinearLayoutManager(this);
            _pieRecyclerView.SetLayoutManager(_pieLayoutManager);

            _pieAdapter = new PieAdapter();
            _pieAdapter.ItemClick += PieAdapter_ItemClick;
            _pieRecyclerView.SetAdapter(_pieAdapter);
            
        }

        private void PieAdapter_ItemClick(object sender, int e)
        {
           var intent = new Intent();
           intent.SetClass(this, typeof(PieDetailActivity));
           intent.PutExtra("selectedPieId", e);
           StartActivity(intent);
        }
    }
}