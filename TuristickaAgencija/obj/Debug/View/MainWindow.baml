   M S B A M L   `   `   `  ����M  ITuristickaAgencija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TuristickaAgencijaTuristickaAgencija  5   	   #    TuristickaAgencija.MainWindow   5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5	   	   @d2http://schemas.microsoft.com/expression/blend/2008     5
   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TuristickaAgencija     5   	      MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	     � Title$  
MainWindow��5   	   $	��550��6   $
��1150��6)   $	��550��66   $
��1150��6F    � WindowStartupLocation$ CenterOwner=�6V   ��5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension   � 	Resources 5       �� DataType#   TuristickaAgencija.Aranžmani"   TuristickaAgencija.Smeštaji    TuristickaAgencija.Prevozi'   !TuristickaAgencija.Administracija!   TuristickaAgencija.Klijenti��%w  (��       5      *, +)(�� 2     5      *, +)(�� d     5      *, +)(�� �     5"      *, +)(�� �     5'      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5!      �� 5"   
   "  6   .R�5$        5&      �� 5'   
   "  6   .R�5)        5+      5-      .��5/      ]� ��. $��
0,0,-0.4,0q�6%   .+�51   
   �� -   5         ��Name$ 
navigation��51      $
��Left=�6)   $��0q�6?   $��Center=�6J   $��Center=�6g   $	��150��6�   .+�53      �� $��
Aranžmani��6   $��0,0,0,10q�6G   ��6)   �� *	ArCommand+6[   �� 55      $��	Smeštaji��6   $��0,0,0,10q�6H   ��6(   �� *SmesCommand+6\   �� 57      $��Prevozi��6   $��0,0,0,10q�6I   ��6'   �� *PrevozCommand+6]   �� 59      $��Klijenti��6   $��0,0,0,10q�6K   ��6(   �� *KlijentCommand+6_   �� 5;      -   5         ��Name$ administracija��5;      $��Administracija��6-   $��0,0,0,10q�6g   ��6F   �� *AdminCommand+6{   �� 5<      -   5        $��	Odjavi se��5<      $��0,0,0,10q�6:   6N   �� 5?      -   5         ��Name$ podacifilijale��5?       " MaterialDesignCaptionTextBlock#��[ 5@      $��Center=�6F   $��0,10,0,0q�6a   $��Center=�6s    �� TextAlignment$ Center=�6�   5B      �� 5D   
   -   5         ��Name$ Pages��5D      $	��995��6(   $��Right=�64   $��	0,0,0,0.4q�6q   ��6K   �� *SelectedViewModel+6q   5F      5G      