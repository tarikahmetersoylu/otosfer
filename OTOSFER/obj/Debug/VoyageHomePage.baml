   M S B A M L   `   `   `  ����B  >OTOSFER, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:OTOSFEROTOSFER  5   	       OTOSFER.VoyageHomePage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:OTOSFER     5   	   -   5          � Title$  VoyageHomePage��5   	   $	��900��6    $
��1200��6-    � AllowsTransparency .  � WindowStyle$
 None=�6T    � 
ResizeMode$ NoResize=�6g    � WindowStartupLocation$ CenterScreen=�6}   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��220 �6    6.   �� 5      6!    � RowDefinitions 5   
   �� 5      $	��200 �6   6+   �� 5      6   .+�5   
   �� $��0��6   $��0��6!   ���	#FF0F408D._�5      �  5      �� 5      $��35 �6$   62   �� 5      6&   .+�5      �� $��img/travel.png��6   $��0��60   $��1��6@   $	��200��6M   $	��110��6Y   6h   �� 5      
������ ._�5      ]� $��Center=�6    $��Center=�6;   .+�5      �� $%��img/seat-belt-on-silhouette.png��6   $��20��6E   6S   �� 5       
�������$
��Bold"�60   $��15(�6B   $��OTOSFER��6Q   $��Center=�6c   $��Center=�6�   6�   5!      5"      5#      5$      �� 5&   
   $��0��6   $��1��6!   ���	#FF0F408D._�5(      �� .+�5)      �� -   5        $��VoyageAddbtn��5)      $��75��6-   
������ ��6R   Z� .��5*      ]� .+�5+      �� $��
Sefer Ekle��6    
�������$��20(�6H   6X   5,      5-      �� 5.      -   5        $��VoyageListbtn��5.      $��75��6.   
������ ��6S   Z� .��5/      ]� .+�50      �� $��Sefer Listele��6    
�������$��20(�6K   6[   51      52      �� 53      -   5        $��PastVoyagebtn��53      $��75��6.   
������ ��6S   Z� .��54      ]� .+�55      �� $��Geçmiş Seferler��6    
�������$��20(�6M   6]   56      57      �� 58      -   5         ��Name$ MountCalculate��58      $��75��61   
������ ��6V   Z� .��59      ]� .+�5:      �� $��Gelir Hesapla��6    
�������$��20(�6K   6[   5;      5<      5=      5?      �� 5A   
   $��1��6   $��0��6!   ���	#FF0F408D._�5B      �  5C      �� 5D      $��35 �6$   62   �� 5E      6&   .+�5G      �� -   5        $��sagust��5G   ,   
�������._�5H      ]� $��80��6    $��Right=�6+   .+�5I      �� $��__��6!   $��35��6.   �� 5J      -   5        $��Close��5J   8   $��X��6!   $��35��6-   6E   5K      5L      �� 5M      -   5        $��golge��5M      $��1��6&   ���	#FF0F408D J� Effect 5N      3  -System.Windows.Media.Effects.DropShadowEffect  5O      	   	Direction$		 200Q�6+   
   Opacity$

 0.20Q�6;   5R      5S      5T      �� 5V   
   $��1��6   $��1��6!   
����+��._�5W      � -	   5        $��icerik��5W      5Y      5Z      5\      5]      