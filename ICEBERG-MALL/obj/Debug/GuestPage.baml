   M S B A M L   `   `   `  ����G  CICEBERG-MALL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ICEBERG_MALLICEBERG_MALL  5          ICEBERG_MALL.GuestPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ICEBERG_MALL     5        N� Title$  	GuestPage��5	       N� WindowTitle$% Добро пожаловать��6    N� 
Background 5
      �� 5   
    �� ImageSource$ /images/startpage.jpg��6   6;   .��5      �  � RowDefinitions 5   
   �� 5      $	��40* �6   �� 5      $
��129* �6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $#��Выбор категории��6   $	��Top=�61   $��Center=�6I   $��0,20,0,5q�6f   $��17(�6x   $
��Bold"�6�   6�   ]� 5      $��Center=�6   $��
20,10,20,0q�64   .+�5      �� $��
Поиск��6   $��Center=�6)   $
��Left=�6D   $��DemiBold"�6_   �� 5      -   5         ��Name$ textBoxCategory��5      
�������$��5,0,0,0q�6I   $��23��6]    �� TextWrapping$
 Wrap=�6j   6~   5      5      �� 5   
   $ Vertical=�6   $��1��6,   .+�5      �� $��1��6   $!��Выбор магазина��6)   $	��Top=�6@   $��Center=�6X   $��0,20,0,5q�6v   $��17(�6�   $
��Bold"�6�   6�   ]� 5      $��Center=�6   $��
20,10,20,0q�63   .+�5       �� $��
Поиск��6   $��Center=�6)   $
��Left=�6D   $��DemiBold"�6_   �� 5!      -   5        $ textBoxTradePoint��5!      $��5,0,0,0q�65   
�������$��23��6]   $
 Wrap=�6j   6~   5"      5#      �� 5$   
   -   5        $��listViewCategory��5$      
�������	 �� DisplayMemberPath$	 NameCategory��6B   $��20,10,20,20q�6c   $��1��6x   6�   �� 5&   
   -   5        $��listViewTradePoint��5&      $��Disabled=�6E   
�������$��1��6�   $��1��6�   $��20,10,20,20q�6�   ��6-   �� ��5'      �� 5(      .R�5)      ]� .+�5*      �  5+      �� 5,   "   $��85 �63   6@   �� 5-   "   65   .+�5/      �� $
��Left=�6(   $��0��6>   $��2,0,2,0q�6N   $��WrapWithOverflow=�6|   $	��Top=�6�   $
��Left=�6�   ��6_   �� 
 �� Path$

 Name�6�   �� 50      $��Right=�6(   $��1��6?   $��WrapWithOverflow=�6t   $��Right=�6�   $��Center=�6�   ��6O   �� $
 Description�6�   51      52      53      55      56      57      