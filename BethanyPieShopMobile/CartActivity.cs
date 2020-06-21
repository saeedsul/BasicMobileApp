using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using BethanyPieShopMobile.Adapters;

namespace BethanyPieShopMobile
{
    [Activity(Label = "CartActivity")]
    public class CartActivity : Activity
    {
        private RecyclerView _cartRecyclerView;
        private RecyclerView.LayoutManager _cartLayoutManager;
        private ShoppingCartAdapter _shoppingCartAdapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cart);
            
            // Create your application here
            _cartRecyclerView = FindViewById<RecyclerView>(Resource.Id.cartRecyclerView);
            _cartLayoutManager = new LinearLayoutManager(this);
            _cartRecyclerView.SetLayoutManager(_cartLayoutManager);
            _shoppingCartAdapter = new ShoppingCartAdapter();
            _cartRecyclerView.SetAdapter(_shoppingCartAdapter);
        }
    }
}