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

        Tournee T1 = new Tournee().AjoutUneTournee(new DateTime(2022, 10, 04), 50, I1);
        await App.Database.SaveItemAsync<Tournee>(T1);


        await App.Database.MiseAJourItemRelation(I1);
        await App.Database.MiseAJourItemRelation(T1);

        ///Act - agir1;
        var mDB = App.Database.GetItemAvecRelations<Tournee>(T1);
        var resultat = mDB.Result;

        var mDBSR = App.Database.GetItemAsync<Inseminateur>(T1.Id);
        var resultat2 = mDBSR.Result;
    }
}