   M S B A M L   `   `   `  ����Q  MCheapLoansProjectPart3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:CheapLoansProjectPart3CheapLoansProjectPart3  5   	   '    !CheapLoansProjectPart3.CheapLoans   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:CheapLoansProjectPart3     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Cheap Loans Form��5
   	      
baseStyles#��[  6"   .��5      � $	��625��6   $	��510��6   .+�5   
   �� ���#ddd$��1q�6$   ._�5      � $	��600��6   $	��510��6      
gridStyles#��[ 6,    � RowDefinitions 5      �� 5      �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      $
��Auto �6$   64   �� 5      .+�5      �� $��1��6     headerStyles#��[ 6%   .��6K   Cheap Loans6X   �� 5!      $��2��6     stackPanelStyles#��[ 6*   .+�5"      �� $
��Bold"�6   .��6.   Customer Name6=   �� 5#      -   5        $��custName��5#        nameTextBoxStyles#��[ 6.    � ToolTip$% First and last name is required��5$      6H   �� 5%      -   5        $��custNameError��5%        errorStyles#��[ 61   5&      �� 5)      $��3��6   #��[ 6*   .+�5*      �� $
��Bold"�6   .��6.   Loan Amount6;   �� 5,        stackPanelBorderStyles#��[ 6   ._�5-      �  � Orientation$ 
Horizontal=�6$   .+�5.      �� $��$��6(    �� Padding$ 4,0,0,0q�61   $��Center=�6C   �� 5/      -   5        $��loanAmt��5/   &     loanAmtStyles#��[ 65   $6 0A value between $0.01 and $99,999.99 is required��50   &   51   H   �� 53       �� Orientation$ Vertical=�6)   .+�54   "   �� -   5        $��cmdUpCur��54   )     upButtonStyles#��[ 55   )   6Q   �� 56   "   -   5        $��
cmdDownCur��56   )    	 downButtonStyles#��[	 57   )   6S   58      59      5:      �� 5;      -   5        $��loanAmtError��5;      #��[ 60   5<      �� 5?      $��4��6   #��[ 6*   .+�5@      �� $
��Bold"�6   .��6.   Annual Interest Rate6D   �� 5B      #��[ 6   ._�5C      � $ 
Horizontal=�6$   .+�5D      �� -   5        $��	anIntRate��5D   &    
 anIntRateStyles#��[
 67   $0 *A value between 0.1% and 99.9% is required��5E   &   5F   J   �� 5H      $��%��6(   $ 0,0,4,0q�61   $��Center=�6C   �� 5J      $ Vertical=�6)   .+�5K   "   �� -   5        $��cmdUpPer��5K   )   #��[ 5L   )   6Q   �� 5M   "   -	   5        $��
cmdDownPer��5M   )   #��[	 5N   )   6S   5O      5P      5Q      �� 5R      -
   5        $��anIntRateError��5R      #��[ 62   5S      �� 5V      $��5��6   #��[ 6*   .+�5W      �� $
��Bold"�6   .��6.   Number of Payments6B   �� 5Y      #��[ 6   ._�5Z      � $ 
Horizontal=�6$   .+�5[      �� -   5        $��numPayments��5[   &     numPaymentsStyles#��[ 69   $+ %A value between 1 and 999 is required��5\   &   5]   L   �� 5_      $ Vertical=�6)   .+�5`   "   �� -   5        $��cmdUpInt��5`   )   #��[ 5a   )   6Q   �� 5b   "   -   5        $��
cmdDownInt��5b   )   #��[	 5c   )   6S   5d      5e      5f      �� 5g      -   5        $��numPaymentsError��5g      #��[ 64   5h      �� 5k      $��6��6   #��[ 6*   .+�5l      �� $
��Bold"�6   .��6.   Monthly Payment6?   �� 5n      #��[ 6   ._�5o      � $ 
Horizontal=�6$   .+�5p      �� $��$��6(   $ 4,0,0,0q�61   $��Center=�6C   �� 5q      -   5        $��
monPayment��5q   &     monPaymentTotalStyles#��[ 68   5r      5s      5t      � 5w      $��7��6     buttonContainerStyles#��[ 6$    � ColumnDefinitions 5x      �� 5y      �� 5z      $
��Auto �6+   �� 5{      $
��Auto �6+   �� 5|      $
��Auto �6+   �� 5}      $
��Auto �6+   �� 5~      .+�5�      �� -   5        $��submit��5�      $��1��6+     submitButtonStyles#��[ 6;   5�      �� 5�      -   5        $��reset��5�      $��2��6*     resetButtonStyles#��[ 6:   5�      �� 5�      -   5        $
��save��5�      $��3��6)     saveButtonStyle#��[ 69   5�      �� 5�      -   5        $��display��5�      $��4��6,     displayButtonStyles#��[ 6<   5�      5�      5�      5�      5�      5�      