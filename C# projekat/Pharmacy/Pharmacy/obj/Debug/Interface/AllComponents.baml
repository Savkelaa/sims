   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Pharmacy.InterfacePharmacy.Interface  5   	   &     Pharmacy.Interface.AllComponents   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Pharmacy.Interface     5   	     � Title$  AllComponents��5   	   $	��450��6   $	��800��6,   .��5	      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF4ED360��6    � Offset$ 0Q�61   � 5      $ White��6   $ 1Q�6-   5       � ColumnDefinitions 5   
   �� 5      $
��128* �6   �� 5      $
��569* �6   �� 5      $	��97* �6    � RowDefinitions 5   
   �� 5      $
��110* �6   �� 5      $
��258* �6   �� 5      $	��51* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridComponent��5         SelectionMode$ Single=�6,   	   AutoGenerateColumns	 .  $��2��6`   $��10,59,125,35q�6t   $��3��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 20* 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 Name��6%   $	 45* 6L    63   �� *Name+6L     5       $ Description��6%   $
 200* 6Z    6:   �� *Description+6Z   5#      �� 5$   
   $��
Search by:��6   $��1��6%   $
��Left=�65   $��
454,10,0,0q�6P   $	��Top=�6d   $��16(�6|   $��31��6�   $��82��6�   �� 5%   
   $��Name:��6   $��1��6    $
��Left=�60   $��
480,74,0,0q�6K   $	��Top=�6_   $��16(�6w   $��31��6�   $��56��6�   �� 5&   
   $��Description:��6   $��1��6'   $
��Left=�67   $��
480,28,0,0q�6R   $	��Top=�6f   $��16(�6~   $��1��6�   $��31��6�   $��94��6�   $��2��6�   �� 5'   
   $��	Medicine:��6   $��1��6$   $
��Left=�64   $��
480,93,0,0q�6O   $	��Top=�6c   $��16(�6{   $��1��6�   $��30��6�   $��78��6�   �� 5(   
   -   5         ��Name$ tbName��5(      $��1��6"   $
��Left=�62   $��23��6M   $��482,105,0,0q�6Y    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��134��6�   $��16(�6�   $��2��6�   $��2��6�   �� 5)   
   -   5        $ tbDesc��5)      $��1��6"   $
��Left=�62   $��23��6M   $��
482,55,0,0q�6Y   $
 Wrap=�6m   $	��Top=�6�   $	��134��6�   $��16(�6�   $��1��6�   $��2��6�   �� 5*   
   $��1:��6   $��1��6   $
��Left=�6-   $��454,123,0,0q�6H   $	��Top=�6]   $��16(�6u   $��1��6�   $��30��6�   $��28��6�   �� 5+   
   $��2:��6   $��1��6   $
��Left=�6-   $��454,165,0,0q�6H   $	��Top=�6]   $��16(�6u   $��1��6�   $��34��6�   $��28��6�   �� 5,   
   -   5        $ tbMedicine1��5,      $��1��6'   $
��Left=�67   $��22��6R   $��482,129,0,0q�6^   $��1��6s   $
 Wrap=�6�   $	��Top=�6�   $	��134��6�   $��2��6�   �� 5-   
   -   5        $ tbMedicine2��5-      $��1��6'   $
��Left=�67   $��24��6R   $��482,173,0,0q�6^   $��1��6s   $
 Wrap=�6�   $	��Top=�6�   $	��134��6�   $��2��6�   5/      50      