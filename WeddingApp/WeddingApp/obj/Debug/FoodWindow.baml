   M S B A M L   `   `   `  ����E  AWeddingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WeddingApp
WeddingApp  5   	       WeddingApp.FoodWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WeddingApp     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
FoodWindow��5	   	   $	��450��6   $	��800��6)    
  FoodVM � DataContext# [  5
   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $��9* �6   6,   �� 5      $��4* �6   6,   .+�5   
   � $��0��6    � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      $
��auto �6    60   �� 5      6"   .+�5      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5      � $��0 0 0 10q�6   .+�5      �� $��5 5 15 5q�6[   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Food Name��6m    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *TENMON+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5      $��5 5 15 5q�6    �� DisplayMemberPath$ TENLOAI��61   $ Style��6�    & "MaterialDesignFloatingHintComboBox#��[ 6�   ��6M   �� *
ListLoai+ �� SelectedItem 6n   �� *LOAIMA+ �� Mode$ TwoWay=�$ PropertyChanged=�6%  �� 5      $��5 5 15 5q�6[   $ Price��6m   #��[ 6�   ��6   �� *DONGIA+$ PropertyChanged=�6�   �� 5      $��5 5 15 5q�6[   $
 Note��6m   #��[ 6�   ��6   �� *GHICHU+$ PropertyChanged=�6�   5      5        5!      $��1��6"   $��5q�6/   .��5"      � .+�5#      �� $��Thêm��6<   $��5q�6K   $	��100��6V   ��6   �� *
AddCommand+6d   �� 5$      $��Sửa��6=   $��5q�6L   $	��100��6W   ��6   �� *EditCommand+6e   �� 5%      $��Xóa��6?   $��5q�6N   $	��100��6Y   ��6   �� *DeleteCommand+6g   5&      5'        5(      $��2��6"   $��5q�6/   $��Stretch=�6:   .��5)      �� $
��Auto=�6   .��5*      �� ��6   �� *List+ 6<   �� *SelectedItem+$ OneWayToSource=�	 �� View	 5+      �� 5,      .P�5-   "   �� $��TENMON��61   
 �� DisplayMemberBinding
 6A   �� *TENMON+6k   �� 5.   "   $
��LOAI��61   
 6?   �� *LOAIMA.TENLOAI+6q   �� 5/   "   $��DONGIA��61   
 6A   �� *DONGIA+6k   �� 50   "   $��GHICHU��61   
 6A   �� *GHICHU+6k   51      53      54      55      56      � 57   
   $��1��6    58      �� 59      $
��auto �6    61   �� 5:      $
��auto �6    61   �� 5;      $
��auto �6    61   �� 5<      6"   .+�5>      (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryLight=�6(   $��16q�6<   $��5q�6I   $��50��6T   $��0��6`   .��5?      �� $"��Quản lý loại thức ăn��6   6;   5@        5A      $��5,5,5,5q�6"   $��61��63   $��1��6?   .��5B      �� $��5q�6Y   $ Loại Thức Ăn��6d   #��[ 6�   $��50��6�   ��6   �� *	TENLOAI+$ PropertyChanged=�6�   5C        5D      $��2��6"   $��5q�6/   $��47��6:   .��5E      � $��2q�6   .+�5F      �� $��5q�6   $��45��6(   ��63   �� *
ThemLoai+.��5G      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$
 Plus=�62   5H      �� 5I      $��5q�6   $��45��6(   ��63   �� *	XoaLoai+.��5J        $ Minus=�62   5K      �� 5L      $��5q�6   $��45��6(   ��63   �� *	SuaLoai+.��5M        $ FindReplace=�62   5N      5O      5P      �� 5Q      $
��Auto=�6   $��5q�6>   $��3��6I   .��5R      �� ��6   �� *
ListLoai+ 6<   �� *SelectedItemLoai+$ OneWayToSource=�	 5S      �� 5T      .P�5U      �� $��Tên Loại��6-   
 6@   �� *	TENLOAI+6k   5V      5X      5Y      5Z      5[      5\      