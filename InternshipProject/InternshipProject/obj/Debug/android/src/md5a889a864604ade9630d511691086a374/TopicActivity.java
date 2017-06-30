package md5a889a864604ade9630d511691086a374;


public class TopicActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("InternshipProject.TopicActivity, InternshipProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", TopicActivity.class, __md_methods);
	}


	public TopicActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == TopicActivity.class)
			mono.android.TypeManager.Activate ("InternshipProject.TopicActivity, InternshipProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
