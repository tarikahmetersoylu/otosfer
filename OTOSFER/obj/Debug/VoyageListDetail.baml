   M S B A M L   `   `   `  ����B  >OTOSFER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OTOSFEROTOSFER  5   	       OTOSFER.VoyageListDetail   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OTOSFER     5   	   -   5          � Title$  VoyageListDetail��5   	   $	��500��6"   $	��800��6/    � AllowsTransparency .  � WindowStyle$
 None=�6U    � WindowStartupLocation$ CenterScreen=�6h   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   6,   �� 5      6"   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      $��10 �6   6,    � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   �� $��Tarih��6   $��0��6    $��1��6-      VoyageListDetailustlbl#���   6>   6q   �� 5   
   $
��Saat��6   $��0��6   $��2��6,   #���   6<   6p   �� 5   
   $��Kalkış Yeri��6   $��0��6&   $��3��63   #���   6C   6w   �� 5   
   $��Varış Yeri��6   $��0��6%   $��4��62   #���   6B   6v   �� 5    
   $��Kaptan Adı��6   $��1��6%   $��1��62     VoyageListDetailaltlbl#���  6B   6u   �� 5!   
   $��Plaka��6   $��1��6    $��2��6-   #���  6=   6q   �� 5"   
   $��Yolcu Kapasitesi��6   $��1��6+   $��3��68   #���  6H   6{   �� 5#   
   $��Bilet Fiyatı��6   $��1��6'   $��4��64   #���  6D   6x   �� 5%   
   -   5         ��Name$ VoyageListDetailtarihtxt��5%      $��0��65   $��1��6B     VoyageListDetailusttxt#���  6R   �� 5&   
   -   5        $ VoyageListDetailsaattxt��5&      $��0��64   $��2��6A   $��	0,0,10,20q�6Q   #���  6d   6�   �� 5'   
   -   5        $# VoyageListDetailkalkisyeritxt��5'      $��0��6:   $��3��6G   #���  6W   6�   �� 5(   
   -   5        $" VoyageListDetailvarisyeritxt��5(      $��0��69   $��4��6F   #���  6V   6�   �� 5*   
   -   5        $ VoyageListDetailkaptantxt��5*      $��1��66   $��1��6C     VoyageListDetailalttxt#���  6S   6�   �� 5+   
   -   5        $ VoyageListDetailplakatxt��5+      $��1��65   $��2��6B   $��	0,0,10,20q�6R   #���  6e   6�   �� 5,   
   -   5        $( "VoyageListDetailyolcukapasitesitxt��5,      $��1��6?   $��3��6L   #���  6\   6�   �� 5-   
   -	   5        $$ VoyageListDetailbiletfiyatitxt��5-      $��1��6;   $��4��6H   #���  6X   6�   �� 50   
   $��2��6   $��1��6!   $��2��6.   ._�51      � .+�52      �� -
   5         ��Name$  VoyageListDetailDuzenlebtn��52      $��Düzenle��6=   $��90��6O   $��30��6Z   $
��Left=�6f   6�   �� 53      -   5        $ VoyageListDetailSilbtn��53      $	��Sil��69   $��90��6G   $��30��6R   $��Center=�6^   6}   �� 54      -   5        $ VoyageListDetailKapatbtn��54      $��Kapat��6;   $��90��6K   $��30��6V   $��Right=�6b   6�   55      57      59      5;      