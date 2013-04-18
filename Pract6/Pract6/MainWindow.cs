using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnLIMPIARClicked (object sender, System.EventArgs e)
	{
		string x="";
		
		entry1.Text=x;
		entry2.Text=x;
		entry3.Text=x;
		entry4.Text=x;
		entry5.Text=x;
		entry6.Text=x;
	}

	protected void OnFACTURARClicked (object sender, System.EventArgs e)
	{
		float producto1=float.Parse(entry1.Text);
		float producto2=float.Parse(entry2.Text);
		float producto3=float.Parse(entry3.Text);
		
		float subtotal= producto1 + producto2 + producto3;
		entry4.Text = subtotal.ToString();
		
		
		double iva= subtotal*.16;
		entry5.Text = iva.ToString();
		
		
		double total= subtotal + iva;
		entry6.Text = total.ToString();
		
		
		
		
	}
}
