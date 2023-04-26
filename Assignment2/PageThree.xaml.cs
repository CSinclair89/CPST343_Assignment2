using System.Collections.ObjectModel;
using Assignment2.Models;

namespace Assignment2;

public partial class PageThree : ContentPage
{
    ObservableCollection<Favorites> FavoritesList = new ObservableCollection<Favorites>();

    public PageThree()
	{
		InitializeComponent();

		Favorites itemOne = new Favorites(312313212, "12:12");
        Favorites itemTwo = new Favorites(1231132312, "21:45");
        Favorites itemThree = new Favorites(312131312, "22:18");
        Favorites itemFour = new Favorites(311231232, "32:13");
        Favorites itemFive = new Favorites(311231322, "62:12");

        Favorites itemSix = new Favorites(313213212, "72:32");
        Favorites itemSeven = new Favorites(3323112, "15:14");
        Favorites itemEight = new Favorites(33213212, "32:12");
        Favorites itemNine = new Favorites(313213212, "52:10");
        Favorites itemTen = new Favorites(312132312, "53:12");

        FavoritesList.Add(itemOne);
        FavoritesList.Add(itemTwo);
        FavoritesList.Add(itemThree);
        FavoritesList.Add(itemFour);
        FavoritesList.Add(itemFive);

        FavoritesList.Add(itemSix);
        FavoritesList.Add(itemSeven);
        FavoritesList.Add(itemEight);
        FavoritesList.Add(itemNine);
        FavoritesList.Add(itemTen);

        collectionView.ItemsSource = FavoritesList;


    }

}