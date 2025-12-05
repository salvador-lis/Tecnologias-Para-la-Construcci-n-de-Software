using AdapterDemo.Framework;
using AdapterDemo.Plugins;

var dashboard = new Dashboard(new Spreadsheet());

dashboard.Render(new Earth());