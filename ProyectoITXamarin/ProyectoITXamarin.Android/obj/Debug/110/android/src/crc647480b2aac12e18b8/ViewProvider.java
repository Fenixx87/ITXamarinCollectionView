package crc647480b2aac12e18b8;


public class ViewProvider
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.devexpress.dxlistview.core.DXListItemViewProvider
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItemCount:()I:GetGetItemCountHandler:Com.Devexpress.Dxlistview.Core.IDXListItemViewProviderInvoker, DevExpress.Xamarin.Android.CollectionView\n" +
			"n_checkView:(Landroid/view/View;I)Z:GetCheckView_Landroid_view_View_IHandler:Com.Devexpress.Dxlistview.Core.IDXListItemViewProviderInvoker, DevExpress.Xamarin.Android.CollectionView\n" +
			"n_getViewByIndex:(I)Landroid/view/View;:GetGetViewByIndex_IHandler:Com.Devexpress.Dxlistview.Core.IDXListItemViewProviderInvoker, DevExpress.Xamarin.Android.CollectionView\n" +
			"n_getViewTypeByIndex:(I)I:GetGetViewTypeByIndex_IHandler:Com.Devexpress.Dxlistview.Core.IDXListItemViewProviderInvoker, DevExpress.Xamarin.Android.CollectionView\n" +
			"n_recycleView:(Landroid/view/View;II)V:GetRecycleView_Landroid_view_View_IIHandler:Com.Devexpress.Dxlistview.Core.IDXListItemViewProviderInvoker, DevExpress.Xamarin.Android.CollectionView\n" +
			"n_updateView:(Landroid/view/View;I)V:GetUpdateView_Landroid_view_View_IHandler:Com.Devexpress.Dxlistview.Core.IDXListItemViewProviderInvoker, DevExpress.Xamarin.Android.CollectionView\n" +
			"";
		mono.android.Runtime.register ("DevExpress.XamarinForms.CollectionView.Android.ViewProvider, DevExpress.XamarinForms.CollectionView.Android", ViewProvider.class, __md_methods);
	}


	public ViewProvider ()
	{
		super ();
		if (getClass () == ViewProvider.class)
			mono.android.TypeManager.Activate ("DevExpress.XamarinForms.CollectionView.Android.ViewProvider, DevExpress.XamarinForms.CollectionView.Android", "", this, new java.lang.Object[] {  });
	}


	public int getItemCount ()
	{
		return n_getItemCount ();
	}

	private native int n_getItemCount ();


	public boolean checkView (android.view.View p0, int p1)
	{
		return n_checkView (p0, p1);
	}

	private native boolean n_checkView (android.view.View p0, int p1);


	public android.view.View getViewByIndex (int p0)
	{
		return n_getViewByIndex (p0);
	}

	private native android.view.View n_getViewByIndex (int p0);


	public int getViewTypeByIndex (int p0)
	{
		return n_getViewTypeByIndex (p0);
	}

	private native int n_getViewTypeByIndex (int p0);


	public void recycleView (android.view.View p0, int p1, int p2)
	{
		n_recycleView (p0, p1, p2);
	}

	private native void n_recycleView (android.view.View p0, int p1, int p2);


	public void updateView (android.view.View p0, int p1)
	{
		n_updateView (p0, p1);
	}

	private native void n_updateView (android.view.View p0, int p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
