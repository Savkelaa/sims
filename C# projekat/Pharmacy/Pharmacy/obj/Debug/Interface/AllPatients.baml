   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Pharmacy.InterfacePharmacy.Interface  5   	   $    Pharmacy.Interface.AllPatients   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Pharmacy.Interface     5   	     � Title$  AllPatients��5   	   $	��450��6   $	��800��6*   .��5	      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF4ED360��6    � Offset$ 0Q�61   � 5      $ White��6   $ 1Q�6-   5       � ColumnDefinitions 5   
   �� 5      $
��130* �6   �� 5      $
��550* �6   �� 5      $
��130* �6    � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $
��318* �6   �� 5      $	��51* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridPatient��5         SelectionMode$ Single=�6*   	   AutoGenerateColumns	 .  $��1��6^   $��3��6k   $��	69,0,70,0q�6   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Jmbg��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Jmbg+6L     5      $ Email��6%   $	 65* 6O    64   �� *Email+6O     5       $ Password��6%   $	 40* 6U    67   �� *
Password+6U     5!      $
 Name��6%   $	 30* 6M    63   �� *Name+6M     5"      $ Surname��6%   $	 40* 6S    66   �� *	Surname+6S     5#      $ MobilePhone��6%   $	 50* 6[    6:   �� *MobilePhone+6[   5%      5'      5(      