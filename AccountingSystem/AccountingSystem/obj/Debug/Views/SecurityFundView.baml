   M S B A M L   `   `   `  ����K  GAccountingSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:AccountingSystem.ViewsAccountingSystem.Views  5      -    'AccountingSystem.Views.SecurityFundView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:AccountingSystem.Views     5        N� Title$  Security_Fund��5      $
��1157��6   $	��717��6*   .��5
      � .+�5   
   �� $��Security Fund��6   $��Center=�6*   $��Center=�6G   $	��336��6b   $��78,322,51,59q�6o   $
��1028��6�   .��5      �  � RowDefinitions 5      �� 5      �� 5      $
��Auto �6$   .+�5      �� $
��Auto=�6   $��5,5,5,5q�6B   .��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6%   $��5,5,5,5q�6>   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ securityFund��5   '      CanUserAddRows .     CanUserDeleteRows .     SelectionMode$ Single=�6n   $	��Top=�6�      AutoGenerateColumns .  $��5,5,5,5q�6�    �� SelectedIndex 6�   �� *SelectedIndex+	   Columns	 5   "   0  *System.Windows.Controls.DataGridTextColumn  5   &   -   5        	tableDate��,  &System.Windows.Controls.DataGridColumn
   Header$

 Date��5   L      Width5  /System.Windows.Controls.DataGridLengthConverter$	 190 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6Z   ��  �� Path$
 Date� �� StringFormat$ d��   HeaderStyle 5   *   �� 5   .    �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  64   .�5   2   ��  �� Property � �� �� Value$ Center=�6_   5   /   5   '     5   &   -   5        tableDetails��$
 Details��5   O   $	 190 6�    6`   �� $ Details� 5   *   �� 5   .   "  64   .�5    2   ��  � ��$ Center=�6_   5!   /   5#   '     5$   &   -   5        tableDeposit��$
 Deposit��5$   O   $	 190 6�    6`   �� $ Deposit� 5%   *   �� 5&   .   "  64   .�5'   2   ��  � ��$ Center=�6_   5(   /   5*   '     5+   &   -   5        tableExpenses��$
 Expenses��5+   P   $	 190 6�    6b   �� $ Expenses� 5,   *   �� 5-   .   "  64   .�5.   2   ��  � ��$ Center=�6_   5/   /   51   '     52   &   -   5        tableRemains��$
 Remains��52   O   $	 190 6�    6`   �� $ Remains� 53   *   �� 54   .   "  64   .�55   2   ��  � ��$ Center=�6_   56   /   58   '   5:      �� 5;      $	��Top=�6d   $��5,5,5,5q�6|    � BindingGroup 6+   �� *UpdateBindingGroup+ �� Mode$ OneWay=�6|   5<      5=      5>      5?      5@      �� 5A   
   $��	Add Entry��6   $��Center=�6&   $��
78,82,51,0q�6C   $	��Top=�6W   $	��200��6o   $
��Auto��6|   .��5B      � $
��1016��6   $��	0,0,0,-12q�6    .+�5C      �� $��	Details :��6   $
��Left=�6,   $��	20,20,0,0q�6G   $	��Top=�6Z   �� 5D      -   5        $��Details��5D      $
��Left=�6)   $��23��6D   $��	90,20,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��200��6�   �� 5E      $��	Deposit :��6   $
��Left=�6,   $��	20,52,0,0q�6G   $	��Top=�6Z   �� 5F      -   5        $��Deposit��5F      $
��Left=�6)   $��23��6D   $��	90,52,0,0q�6P   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��200��6�   �� 5G      $��
Expenses :��6   $
��Left=�6-   $��	20,84,0,0q�6H   $	��Top=�6[   �� 5H      -	   5        $��Expenses��5H      $
��Left=�6*   $��23��6E   $��	90,84,0,0q�6Q   $
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��200��6�   �� 5I      -
   5        $
��Save��5I      $
��Left=�6(   
�����F�$��904,143,0,0q�6Z   $	��Top=�6o   $��78��6�   $��25��6�   6�   5J      5K      �� 5L   
   $��Security Fund��6   $
��Left=�6(   $��	78,28,0,0q�6C   $	��Top=�6V   $	��194��6n   $��24(�6z   $
��Bold"�6�   5M      5N      