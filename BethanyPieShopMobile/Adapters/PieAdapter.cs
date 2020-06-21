using System;
using System.Collections.Generic;
using Android.Support.V7.Widget;
using Android.Views;
using BethanyPieShopMobile.Shared.Models;
using BethanyPieShopMobile.Shared.Repository;
using BethanyPieShopMobile.Utility;
using BethanyPieShopMobile.ViewHolders;

namespace BethanyPieShopMobile.Adapters
{
    public class PieAdapter : RecyclerView.Adapter
    {
        public event EventHandler<int> ItemClick;
        private List<Pie> _pies;
        public PieAdapter()
        {
            var pieRepository = new PieRepository();
            _pies = pieRepository.GetAllPies();
        }

        public override int ItemCount => _pies.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (!(holder is PieViewHolder pieViewHolder)) return;

            pieViewHolder.PieNameTextView.Text = _pies[position].Name;

            var imageBitmap = ImageHelper.GetImageBitmapFromUrl(_pies[position].ImageThumbnailUrl);
            pieViewHolder.PieImageView.SetImageBitmap(imageBitmap);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView =
                LayoutInflater.From(parent.Context).Inflate(Resource.Layout.pie_viewholder, parent, false);

            var pieViewHolder = new PieViewHolder(itemView, OnClick);
            return pieViewHolder;
        }

        private void OnClick(int position)
        {
            var pieId = _pies[position].PieId;
            ItemClick?.Invoke(this, pieId);
        }
    }
}