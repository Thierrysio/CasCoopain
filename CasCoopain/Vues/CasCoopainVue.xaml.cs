using CasCoopain.Modeles;
using CasCoopain.VueModeles;

namespace CasCoopain.Vues;

public partial class CasCoopainVue : ContentPage
{
	CasCoopainVueModele vueModele;
	public CasCoopainVue()
	{
		InitializeComponent();
		BindingContext = vueModele = new CasCoopainVueModele();
		this.test();
	}

	public async void test()
	{
        ///Arrange - organiser
        Inseminateur I1 = new Inseminateur().AjoutInseminateur("inseminateur 01", "prenom 01", "0654254794", "tlg", "pwd");
        await App.Database.SaveItemAsync<Inseminateur>(I1);

        await App.Database.MiseAJourItemRelation(I1);


        ///Act - agir1);
        var mDB = App.Database.GetItemAvecRelations<Inseminateur>(I1);
        var resultat = mDB.Result;
    }
}