   M S B A M L   `   `   `  ����G  CICEBERG-MALL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ICEBERG_MALLICEBERG_MALL  5      %    ICEBERG_MALL.EditTradePointPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:ICEBERG_MALL     5        N� Title$  EditTradePointPage��5	      .��5
      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      $	��150 �6   6+   �� 5      6   .+�5   
   �� $<��6Редактировать торговую точку��6   $��Center=�68   $��Bottom=�6U   $��20(�6p   $��0,0,0,40q�6~   6�   �� 5   
    �� Orientation$ Vertical=�6   $��1��6,   .+�5      �� -   5        $��textBoxEditTradePointName��5      $	��Top=�68   $��
50,10,50,0q�6P    �� TextWrapping$
 Wrap=�6d   �� 5      -   5        $&�� textBoxEditTradePointDescription��5      $��Center=�6>   $
 Wrap=�6Y   $��
50,20,50,0q�6m   $��50��6�   6�   �� 5      -   5         ��Name$ comboBox��5      $��
50,20,50,0q�6)    �� DisplayMemberPath$ NameCategory��6b   $	��Top=�6�   $��20��6�   ��6=   �� *NameCategory+6�   5      � 5   
   $��2��6   $��Right=�6!   $��Center=�6=   $��	0,10,20,0q�6X   .+�5      �� -   5        $��buttonEditTradePointOk��5      $��70��63   $��30��6A   $��5q�6P   $ ��Редактировать��6[   6�   �� 5      -   5        $ ��buttonEditTradePointCancel��5      $��30��67   $��Отмена��6F   $��5q�6W   $��70��6c   6�   5      5      5      