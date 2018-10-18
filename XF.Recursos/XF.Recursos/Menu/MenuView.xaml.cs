using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;

namespace XF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        public ListView ListView { get { return lstMenu; } } //Nome lstMenu deve ser identica no XAML
        public MenuView()
        {
            InitializeComponent();
            //Carregando os itens do Menu
            ObservableCollection<OpcoesMenu> menuItems = new ObservableCollection<OpcoesMenu>();
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Home",
                Icone = "Home.png",
                TargetType = typeof(HomeView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Editor",
                TargetType = typeof(Controles.EditorView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Controle de Data",
                TargetType = typeof(Controles.PickerView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "List Picker",
                TargetType = typeof(Controles.ListPickerView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Stepper",
                TargetType = typeof(Controles.StepperView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Progresso",
                TargetType = typeof(Controles.ProgressoView)
            });

            lstMenu.ItemsSource = menuItems;
        }


    }
}