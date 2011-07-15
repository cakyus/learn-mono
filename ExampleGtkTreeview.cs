//
// Example of using GtkWindow
// 
// Compile like this"
// mcs -pkg:gtk-sharp-2.0 GtkHello.cs

using System;
using Gtk;

public class GtkHello {
	
	public static void Main() {
		
		Application.Init();
		
		// creating components
		Window myWin = new Window("My First Gtk# Application");
		Label myLabel = new Label();
		
		myWin.Resize(200,200);
		myLabel.Text = "Hello World";
		myWin.Add(myLabel);
		
		// event handlers
//		myWin.DeleteEvent += new DeleteEventHandler(Window_Delete);
		myWin.DeleteEvent += Window_Delete;
		
		myWin.ShowAll();
		
		Application.Run();
	}
	
	static void Window_Delete(object o, DeleteEventArgs args) {
		Application.Quit();
	}
}

