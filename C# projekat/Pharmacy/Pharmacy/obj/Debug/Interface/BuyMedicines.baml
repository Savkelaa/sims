   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Pharmacy.InterfacePharmacy.Interface  5   	   %    Pharmacy.Interface.BuyMedicines   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Pharmacy.Interface     5   	     � Title$  BuyMedicines��5   	   $	��450��6   $	��800��6+   .��5	      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF4ED360��6    � Offset$ 0Q�61   � 5      $ White��6   $ 1Q�6-   5       � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $	��50* �6   �� 5      $	��20* �6   �� 5      $
��280* �6   �� 5      $	��30* �6    � ColumnDefinitions 5   
   �� 5      $	��26* �6   �� 5      $	��67* �6   �� 5      $
��197* �6   �� 5      $	��90* �6   �� 5      $	��42* �6   �� 5      $
��145* �6   �� 5      $	��54* �6   �� 5       $
��143* �6   �� 5!      $	��29* �6   .+�5#   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridAccepted��5#         SelectionMode$ Single=�6a   	   AutoGenerateColumns	 .  $��1��6�   $��2��6�   $��4��6�   $��0.4,20.4,40.4,31q�6�   $��3��6�   
 �� SelectedItem
 6*   �� *SelectedMedicine+ �� Mode$ TwoWay=�   Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 20* 6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6I     5&      $
 Name��6%   $	 50* 6M    63   �� *Name+6M     5'      $ Manufacturer��6%   $	 70* 6]    6;   �� *Manufacturer+6]     5(      $ Price��6%   $	 27* 6O    64   �� *Price+6O     5)      $ Quantity��6%   $	 35* 6U    67   �� *
Quantity+6U   5+        5,   
   -   5        $
 cart��5,      $��5��6$   $��2��64   $��3��6A   $��1.6,20.4,0.8,31q�6U   $��3��6n    5-        5.      $ Id��6%   $	 20* 6I    61   �� *Id+6I     5/      $
 Name��6%   $	 50* 6L    63   �� *Name+6L     50      $ Manufacturer��6%   $	 70* 6]    6;   �� *Manufacturer+6]     51      $ Price��6%   $	 27* 6O    64   �� *Price+6O     52      $ Quantity��6%   $	 35* 6T    67   �� *
Quantity+6T   54      �� 55   
   -   5        $��Add to cart��55      $��2��6'   $��1��69   $��16(�6F   $��3.2,0.2,90,20.4q�6n   $��2��6�   $��2��6�   �� 56   
   -   5        $��Delete from cart��56      $��4��6,   $��1��6>   $��16(�6K   $��42,0.2,0.2,20.4q�6x   $��2��6�   $��2��6�   �� 57   
   -   5        $	��Buy��57      $��7��6   $��1��61   $��16(�6>   $��0.4,0.2,28.6,20.4q�6^   $��2��6y   $��2��6�   58      59      