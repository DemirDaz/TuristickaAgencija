   M S B A M L   `   `   `  ����M  ITuristickaAgencija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TuristickaAgencijaTuristickaAgencija  5      #    TuristickaAgencija.Aranžmani   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:TuristickaAgencija     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5         MaterialDesignBody#���   5	      $��Medium"�5      $��14(�5      
���iii���5      :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension  .��5      �   � ColumnDefinitions  5   
   �� 5      �� 5      $��7* �6    � RowDefinitions 5   
   �� 5      $	��53* �6   �� 5      $	��51* �6   .+�5   
   �� -   5         ��Name$ sakrij��5      $��
10,0,0,250q�6%   $
��Left=�69   $	��150��6U   $��2��6a   $��2��6u   .+�5      �� -   5         ��Name$	 one��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Destinacija��5       % !MaterialDesignFloatingHintTextBox#��[ 5      $��Center=�5      $��0,0,0,3q�6)   (  "System.Windows.Controls.DatePicker  5       -   5          Name$	 two��5       $	��150��5!      $��Stretch=�6   $ Datum Početka��5"       ( $MaterialDesignFloatingHintDatePicker#��[ 5#        5$      -   5        $ three��5$      $ Datum Završetka��5%      #��[ 5&      $��0,0,0,0q�6A   �� 5'      -   5        $
 four��5'      $ Cena po osobi (€)��5(      #��[ 5)      $��Center=�5*      $��0,0,0,3q�6)   �� 5+      -   5         ��Name$
 five��5+      $ Način plaćanja��5,      $��Center=�5.      $��0,0,0,3q�6)   .@�5/      �� .��6   Keš/Kartica6,   �� 50      .��6   6/9/12 mesečnih rata65   �� 51      .��6   	Čekovi6'   53      �� 54      -   5         $  MaterialDesignRaisedAccentButton#��[ 55       � ToolTip$5 /Resource name: MaterialDesignRaisedAccentButton��56      $��0,0,0,0q�6H   $��Dodaj aranžman!��6n   $��34��6�   $��Medium"�6�   59      �� 5:   
    $  MaterialDesignHeadline2TextBlock#��[ 5;      $��133.2,235,92,0q�6?   $	��650��6W   $	��Top=�6c    �� TextAlignment$ Center=�6{   $��Center=�6�   	 J� RenderTransformOrigin$	 0.178,1.008&�6�   $��2��6�   $��67��6�   $��1��6�   �� 6  $�
ARANŽMANI��6  6  &   System.Windows.Controls.DataGrid  5<   
   -   5        
  Name$
 grid1��5<         CanUserAddRows .     SelectionUnit$ FullRow=�5>         
IsReadOnly .    SelectionMode$ Extended=�5@      $
��Left=�6   $��97.2,0,0,23.8q�67   $��1��6N   ��5A      �� 5B       �� ImageSource$< 6/TuristickaAgencija;component/Resources/darkaranz3.jpg��6    j� Stretch$ UniformToFill=�6b   5D        5E   
   -	   5        $
 grid2��5E       .  $ FullRow=�5G       . $ Extended=�5I      $
��Left=�6&   $��97.2,37.2,0,0q�6A   $��1��6X   $��1��6e   ��5J      �� 5K      $< 6/TuristickaAgencija;component/Resources/darkaranz4.jpg��6   5M      �� 5N   
   -
   5         ��Name$ sakrijdugme��5N       * &MaterialDesignFloatingActionMiniButton#��[ 6'   $
��Left=�5O      $, &MaterialDesignFloatingActionMiniButton��5P      $��1��6N   $��44.2,203,0,17.8q�6^   .��5Q      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Delete=�6&   $��24��64   $��24��6@   5R      �� 5S   
   $��10,80.2,0,-38q�6   $
��Left=�6,   $	��150��6H   $��1��6T   $��2��6a   .+�5T      �� -   5        $ idaranz��5T      $ id Aranžmana��5U      $��	0,5,0.4,5q�6<   $��28��6O   5W      �� 5X      -   5        $
 jmbg��5X      $ jmbg klijenta��5Y      $	��0,5q�6=   5[      �� 5]      -   5        $ four1��5]      $ Broj osoba:��5^      #��[ 5_      $��Center=�5`      $��
2,0,-1.6,5q�6,   �� 5a      -   5        #��[ 5b      $5 /Resource name: MaterialDesignRaisedAccentButton��5c      $��
0,0,-1.6,0q�6K   $��Dodaj rezervaciju!��6u   $��35��6�   $	 0.629,-1.975&�6�   $��Center=�6�   $��Center=�6�   $	��152��6�   5g      �� 5h   
   -   5        #��[ 5h      $
��Left=�5i      $, &MaterialDesignFloatingActionMiniButton��5j      $��1��6>   $��44.2,201,0,10q�6N   $��1��6e   .��5k        $ Delete=�6&   $��24��64   $��24��6@   5l      5m      5n      