   M S B A M L   `   `   `  ����C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Pharmacy.InterfacePharmacy.Interface  5   	   *    $Pharmacy.Interface.MedicinesRequests   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Pharmacy.Interface     5   	     � Title$  MedicinesRequests��5   	   $	��450��6#   $	��800��60   .��5	      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF4ED360��6    � Offset$ 0Q�61   � 5      $ White��6   $ 1Q�6-   5       � RowDefinitions 5   
   �� 5      $
��102* �6   �� 5      $
��257* �6   �� 5      $	��60* �6    � ColumnDefinitions 5   
   �� 5      $	��71* �6   �� 5      $
��398* �6   �� 5      $
��323* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ gridRequests��5         SelectionMode$ Single=�6)   	   AutoGenerateColumns	 .  $��3��6\   $��39,65,259,38q�6p   $��3��6�   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 20* 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $
 Name��6%   $	 50* 6L    63   �� *Name+6L     5       $ Manufacturer��6%   $	 70* 6\    6;   �� *Manufacturer+6\     5!      $ Price��6%   $	 50* 6N    64   �� *Price+6N     5"      $ Quantity��6%   $	 50* 6T    67   �� *
Quantity+6T   4  .System.Windows.Controls.DataGridTemplateColumn  5#      $ 
Components��6)   $	 70* 6=      CellTemplate 5$      �� 5%      .R�5&      �� ��6+   �� *
Components+5'      5)      5,      �� 5-   
   -   5        $��Accept��5-      $��2��6"   $
��Left=�62   $��
121,66,0,0q�6M   $	��Top=�6a   $	��130��6y   $��60��6�   $��16(�6�   $��2��6�   �� 5.   
   -   5        $��Reject��5.      $��2��6"   $
��Left=�62   $��
121,56,0,0q�6M   $��1��6a   $	��Top=�6n   $	��130��6�   $��60��6�   $��16(�6�   5/      51      