   M S B A M L   `   `   `  ����Q  MCheapLoansProjectPart3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CheapLoansProjectPart3CheapLoansProjectPart3  5   	   )    #CheapLoansProjectPart3.DisplayLoans   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   6local$clr-namespace:CheapLoansProjectPart3     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Display Loans Form��6.      
baseStyles#��[  6I   .��5      � $	��650��6   $	��600��6   .+�5   
   �� ���#ddd$��1q�6$   ._�5      � $	��625��6   $	��600��6     � RowDefinitions 5      �� 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      .+�5      �� $��1��6     headerStyles#��[ 6%   .��6K   Display Loans6Z   &   System.Windows.Controls.DataGrid  5      -   5        $��loans��5   (   $��2��6     loansDataGridStyles#��[ 65      RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    .�5       ��  �� Property �@�Cursor �� Value$
 Hand��67   5!      5#      �� 5&      $��3��6     stackPanelStyles#��[ 6*   .+�5'      �� $
��Bold"�6   .��6.   Total Loan Amount6A   �� 5)        stackPanelBorderStyles#��[ 6   ._�5*      �  � Orientation$ 
Horizontal=�6$   .+�5+      �� $��$��6(    �� Padding$ 4,0,0,0q�61   $��Center=�6C   �� 5,      -   5        $��total��5,   &     monPaymentTotalStyles#��[ 63   5-      5.      5/      � 51      $��4��6     buttonContainerStyles#��[ 6$   	 � ColumnDefinitions	 52      �� 53      �� 54      $
��Auto �6+   �� 55      $
��Auto �6+   �� 56      .+�5:      �� -   5        $��cheapLoansLink��5:   -   $��1��6     cheapLoansLinkStyle#��[ 5;      
 � ToolTip$
 Return to Cheap Loans��6J   5<      �� 5?      -   5        $��reset��5?   -   $��2��6     clearButtonStyles#��[ 6:   5@      5A      5B      5C      5D      5E      