   M S B A M L   `   `   `  ����E  AWeddingApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WeddingApp
WeddingApp  5          WeddingApp.BookingManage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $localclr-namespace:WeddingApp  5      .��5
      � ���#EDE7F6.+�5   
   �� .+�5      � $��85��6   $��
0,0,-0.4,0q�6   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone      Mode$  PrimaryDark=�6+      CornerRadius$ 3��6>   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5   +   $��20q�5   +   $��Right=�69   $	��450��6U   $��Bottom=�6a   $��0,30,0,0q�6|   .��5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��Center=�6$   $��16 0 0 0q�6?   BOOKING THE PARTY5      5      5      5      ]� 5      .+�5      �� $��60 10 10 10q�6   $	��250��63   .+�5      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Chon Tiec Cuoi��6   $��6 0 8 0q�6P   ��5      �� 5      .R�5   "   $� 5      5       �� 5!      
���   �$��2q�61   $��5 30 5 5q�6E   ._�5"      ��  
  FoodVM � DataContext# [  6%   .+�5#      �� $��
SelectFood��6(   $��	8,8,151,0q�6:   
����� � �� TextAlignment$ Center=�6c   6|   �� 5$      $ FoodName��6'      HintOpacity$	 .26Q�6Q   $
��Left=�6}   $	��218��6�   $��8,8,0,8q�6�    �� DisplayMemberPath$ TENMON��6�   ��6�   �� *List+6�   ]� 5%      .+�5&   "   �� $
 Loai��6+   	 �� 
IsEditable	 . $	 .26Q�6c   $
��Left=�6�   $��8,8,0,8q�6�   $	��110��6�   $ TENLOAI��6�   ��6�   �� *
ListLoai+6  �� 5'   "   $ Số Lượng��6*    % !MaterialDesignFloatingHintTextBox#��[ 6T   $��0 0 0 9q�6�   $��95��6�   5(      �� 5)      .+�5*   "   �� -   5        
 ��Name$2
 ,MaterialDesignTextAreaTextBoxEnabledComboBox��5*   +    d� 	IsChecked$
 TrueY�6a   $��10,10,10,10q�6r   .��6�   
TakeNote5,   #   �� 5-   "   $��
10,0,10,10q�6*   $	��Top=�6>   $	��100��5.   *    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�50   *   " �� VerticalScrollBarVisibility$
 Auto=�51   *   $ This is a text area��52   *   {�53   *   ��  �� Path$ 	IsChecked� �� ElementName$2 ,MaterialDesignTextAreaTextBoxEnabledComboBox��54      55      56      �� 57      $ 
Horizontal=�6!   .+�58      �� $	��180��6!   $��6 0 0 0q�6-   $��Food Manage��6>   ��6T   �� *FoodCommand+6v   �� 59      $��50��6!   $��2q�6,   .��5:      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=null]]   Kind$ 
ArrowRight=�66   5;      5<      5=      �� 5?      $	��256��6   $��
0 62 10 10q�6)   $	��311��6=   .+�5@      �� 
���   �$��2q�61   $	��257��6E   $��10 10 10 10q�6R   ._�5A      �� $��0.4,-1.6,0.6,3.4q�6%   .+�5B      �� $��SelectServices��6(   $��8,8,116.8,0q�6>   
����� �$ Center=�6i   6�   �� 5C      $ ServiceName��6'   	 . $	 .26Q�6f   $
��Left=�6�   $	��218��6�   $��8,8,0,8q�6�   5D      ]� 5E      .+�5F   "   �� $ Số Lượng��6*   #��[ 6T   $��8q�6�   $
��auto��6�   5G      �� 5H      $	��136��6)   $��	0,0,0.2,0q�66   .+�5I   "   �� $
 TrueY�6+   $��
10,0,0.4,8q�6<   $��30��6P   .��6\   
TakeNote5K   #   �� 5L   "   $��
10,0,10,10q�5M   !   $	��Top=�5N   !   $��88��5O   !    . $
 Wrap=�5Q   !   $
 Auto=�5R   !   $ This is a text area��5S   !   {�5T   !   �� $ 	IsChecked�$2 ,MaterialDesignTextAreaTextBoxEnabledComboBox��5U      5V      5W      �� 5X      $ 
Horizontal=�6!   .+�5Y      �� $	��180��6!   $��10 0 0 0q�6-   $��Service Manage��6?   ��6X   �� *ServiceCommand+6}   �� 5Z      $��50��6!   $��2q�6,   .��5[        $ 
ArrowRight=�66   5\      5]      5^      � 5`       � RowDefinitions 5a      �� 5b      $��1* �6(   66   �� 5c      $��5* �6(   66   �� 5d      $��5* �6(   66   .+�5f      �� $��0��6    $��Menu Of Party��6-   $��Center=�6B   $ Center=�6]   $
��Bold"�6t   
��� ���$��8 0 8 0q�6�   6�   #  MaterialDesignThemes.Wpf.Card  5g      $��8q�6*   $��Stretch=�65   $��Stretch=�6Q   $��1��6o   .��5h      �� .��5i      �� -   5         �� SelectedItem 5i   '   �� *SelectedItem+ �� Mode$ OneWayToSource=� �� View 5j   "   �� 5k   &   .P�5l   *   �� $��FoodName��69   6N   �� 5m   *   $
��Kind��69   6I   �� 5n   *   $��Amount��69   6K   �� 5o   *   $��Price��69   6J   �� 5p   *   $
��Note��69   6I   5q   '   5s      5t      5u        5v      $��8q�6*   $��Stretch=�65   $��Stretch=�6Q   $��2��6o   .��5w      �� .��5x      �� -   5         5x   '   �� *SelectedItem+$ OneWayToSource=� 5y   "   �� 5z   &   .P�5{   *   �� $��FoodName��69   6N   �� 5|   *   $��Amount��69   6K   �� 5}   *   $��Price��69   6J   5~   '   5�      5�      5�      5�      5�      �� 5�      $ 
Horizontal=�6   $��0,0,8,0q�62   $��Right=�6C   $	��299��6_   .+�5�      �� $	��144��6   $��0 0 8 0q�6%   $��Delete��66   6J   �� 5�      $	��138��6   $
��Save��6%   67   5�      5�      5�      5�      