   M S B A M L   `   `   `  ����C  ?DataGrid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DataGridDataGrid  5   	       DataGrid.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DataGrid     5   	     � Title$  
MainWindow��5   	   $	��499��6   $	��700��6)    � 	Resources 5	         MaleTemplate �� Path  FemaleTemplate%  DataGrid.GenderTemplateSelector  genderTemplateSelector   MaleTemplate   FemaleTemplate��%�   &	        &	 X     &	 �     7   7  �� 5
   
   .R�5      �� 
����  ���6   �� $ Description�6:   5      �� 5   
   .R�5      �� 
���������6   �� $ Description�6:   5        5   
   8   8  5      5      .��5      �� .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridOfPeople��5   &      SelectionUnit$ CellOrRowHeader=�5         SelectionMode$ Extended=�5         CanUserAddRows .  	   CanUserDeleteRows	 .  
   AlternatingRowBackground

 ����� �� AlternationCount$ 2��5   3      FrozenColumnCount$ 1��5         HeadersVisibility$	 All=�5         AutoGenerateColumns .  !   RowDetailsTemplateSelector# [ 5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� $
 Name�   	CellStyle 5$      �� 5%       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�5&      ��  �� Property � �� �� Value
 � �|�6;   5'         HeaderStyle 5)      �� 5*      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5+      ��  � ��$ 	UltraBold"�6;   5,         HeaderTemplate 5.      �� 5/      .R�50      �� ��6(   �� 51      53        54      $	 Age��6%    62   �� $	 Age�  55      $ @��6%    60   �� $ Email�4  .System.Windows.Controls.DataGridCheckBoxColumn  56      $ 
Newsletter��6)    6=   �� $ isSubscribedToNewsletter�5	  /System.Windows.Controls.DataGridHyperlinkColumn	  57      $	 WWW��6*    67   �� $ Website�4
  .System.Windows.Controls.DataGridComboBoxColumn
  58      $	 Sex��6)   -   5        ComboBoxColumnSex�� 
  SelectedValueBinding 58   Q   �� $ 
GenderType�4  .System.Windows.Controls.DataGridTemplateColumn  59      $ Image��6)      CellTemplate 5:      �� 5;      .R�5<      �� $��50��6B   ��6$   �� $ Image�6B   5=      5?         RowStyle 5A      �� 5B      )  #System.Windows.Controls.DataGridRow"  6   .�5C      ��  � ��
 �����63   5D      5G      5H      5J      