using System;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace BethanyPieShopMobile.ViewHolders
{
    public class CartViewHolder : RecyclerView.ViewHolder
    {

        public ImageView PieImageView { get; set; }
        public TextView PieNameTextView { get; set; }
        public TextView PieAmountTextView { get; set; }

        public CartViewHolder(View itemView, Action<int> listener) : base(itemView)
        {
            PieImageView = itemView.FindViewById<ImageView>(Resource.Id.pieImageView);
            PieNameTextView = itemView.FindViewById<TextView>(Resource.Id.pieNameTextView);
            PieAmountTextView = itemView.FindViewById<TextView>(Resource.Id.pieAmountTextView);

            itemView.Click += (sender, e) => listener(base.LayoutPosition);
        }
    }
}