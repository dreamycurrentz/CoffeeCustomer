   M S B A M L   `   `   `  ����J  FCoffeeCustomers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CoffeeCustomersCoffeeCustomers  5   	        CoffeeCustomers.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CoffeeCustomers     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��500��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6    �� 5      �� 5      $
��Auto �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��3��6   ���#F05A28 �� Orientation$ 
Horizontal=�6>   .+�5      �� $��Images/logo.png��6   $��90��6-   $��5q�69   �� 5      $��Coffee Customers��6   $��30(�5      
�������$��Bottom=�5      $��20q�5      �� 5      $��Version 1.0��6   ���#333333$��Bottom=�5      $��0 0 0 25q�5      5       � 5#   
   -   5         �Name$ customerListGrid��5$      $��1��5#      $��0��6   ���#eeeeee 5%      �� 5&      $
��Auto �6    �� 5'      .+�5*      �� $ 
Horizontal=�6   .+�5+      �� -   5        $��10q�5+      .��5,      �� $
��Move��6    $��5 0 5 0q�6,   5-      �� 5.      -   5        $��10q�5.      .��5/      �� $	��Add��6    $��5 0 5 0q�6+   50      �� 51      -   5        $��10q�51      .��52      �� $��Delete��6    $��5 0 5 0q�6.   53      54      �� 56      -   5         ��Name$ customerListView��56   $   $��1��6    �� DisplayMemberPath$ 	FirstName��6>   57      �� 5:   
   $��1��6   $��1��6"   .+�5;      �� $��	Firstname��6   $��
10 10 10 2q�6)   �� 5<      $��	10 0 10 0q�6   �� 5=      $��Lastname��6   $��
10 10 10 2q�6(   �� 5>      $��	10 0 10 0q�6   �� 5?      $��Is developer?��6   $��
10 10 10 0q�6/   5@      5A      5C      