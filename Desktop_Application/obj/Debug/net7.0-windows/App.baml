   M S B A M L   `   `   `  ����N  JDesktop_Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Desktop_ApplicationDesktop_Application  5      b ^PresentationFramework.Aero2, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes 5          Desktop_Application.App   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      3local!clr-namespace:Desktop_Application     5      ^ ZMahApps.Metro.IconPacks, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.BootstrapIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag	 cMahApps.Metro.IconPacks.BoxIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag
 cMahApps.Metro.IconPacks.Codicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Coolicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Entypo, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.EvaIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak gMahApps.Metro.IconPacks.FeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.FileIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah dMahApps.Metro.IconPacks.Fontaudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.FontAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Fontisto, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj fMahApps.Metro.IconPacks.ForkAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Ionicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.JamIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137am iMahApps.Metro.IconPacks.MaterialDesign, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.MaterialLight, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af bMahApps.Metro.IconPacks.Microns, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ae aMahApps.Metro.IconPacks.Modern, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Octicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.PicolIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137al hMahApps.Metro.IconPacks.PixelartIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai eMahApps.Metro.IconPacks.RadixIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah  dMahApps.Metro.IconPacks.RemixIcon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ai! eMahApps.Metro.IconPacks.RPGAwesome, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj" fMahApps.Metro.IconPacks.SimpleIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag# cMahApps.Metro.IconPacks.Typicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137af$ bMahApps.Metro.IconPacks.Unicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137aj% fMahApps.Metro.IconPacks.VaadinIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ak& gMahApps.Metro.IconPacks.WeatherIcons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ah' dMahApps.Metro.IconPacks.Zondicons, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137axIcon-http://metro.mahapps.com/winfx/xaml/iconpacks!   	 
                        ! " # $ % & ' 5      �themeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2!   	 
                        ! " # $ % & ' 5        �� 	Resources  5         	titleText �� 
TargetType �� Property �� Value  
normalText  
mainButton �� 
TargetType �� CornerRadius �� Padding �� Triggers P� Property	 P� Value  circleButton
 �� ScaleX �� ScaleY  minimizeButton  closeButton �� BasedOn  maximizebutton  confirmDeleteButton  logoutButton 	 cancelDeleteButton 
 textHint  textBox  textblockcaption  gridEditButton  gridRemoveButton  grideditconformbutton  grideditcancelbutton  gridButtonIcon.  (MahApps.Metro.IconPacks.PackIconMaterial  DataGridStyle1&   System.Windows.Controls.DataGrid5  /System.Windows.Controls.DataGridLengthConverter J� SnapsToDevicePixels ��Name � ColumnDefinitions � RowDefinitions   SelectAllCommand �� 
ResourceId �� TypeInTargetAssembly7  1System.Windows.Controls.DataGridHeadersVisibility
   All �� ConverterParameter!   HeadersVisibilityConverter �� 	Converter �� RelativeSource �� AncestorTypeG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter  Name   Column ��Name �� CanContentScroll ��Name �� ScrollableHeight  � Maximum! �� Orientation" �� ViewportHeight# �� ViewportSize*$ �� #ComputedVerticalScrollBarVisibility% � Value& �� Mode' �� ScrollableWidth( �� ViewportWidth,) �� %ComputedHorizontalScrollBarVisibility* ]� 
Conditions+ �� Property, �� Value  ColumnHeaderGripperStyle- ��Name. �Name/ J� Opacity0 � Points1 �� Stretch2 �� Triggers3 �� 
TargetName  DataGridCellStyle1*  $System.Windows.Controls.DataGridCell)  #System.Windows.Controls.DataGridRow4 �� Path  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader5 �� EndPoint6 �� 
StartPoint7 � Color8 � Offset3	  -Microsoft.Windows.Themes.DataGridHeaderBorder9 	  	IsPressed: J� IsMouseOver; 	  	IsHovered<   CanUserSort= 	  IsClickable>   SortDirection? 	  SortDirection@   SeparatorVisibilityA 	  SeparatorVisibilityB   SeparatorBrushC 	  SeparatorBrushD n�Name  DataGridRowStyle1E ��Name?
  9System.Windows.Controls.Primitives.SelectiveScrollingGrid?  9System.Windows.Controls.Primitives.DataGridCellsPresenterF   
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenterG   DetailsVisibility$H 
  SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientationI   Vertical#J   RowDetailsScrollingConverter:  4System.Windows.Controls.Primitives.DataGridRowHeader
K   Row��%:9  &	        &	 �     &	 �    &	 N    &	 �    &	 �
    7  &	     7  &	 =    &	 q    7  &		 Y    &	
 �    &	 v    &	 �    &	 @    &	     7  &	     7  &	 �    7  &	 �    &	 }    &	 �)    (�� �*    5�     $" DataGridSelectAllButtonStyle��"  )&	 |-    &	 8/    7  7  &	 3    �� 5	   
   " ��6"   .�5
      ��  � ��$ 36(�6)   �� 5       � ��$
 Bold"�6+   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � �� �#3AB19B6+   5      �� 5   
   " ��6#   .�5      ��  � ��$ 16(�6)   �� 5       �@��
LineHeight$ 28��6+   �� 5       � ��$
 Wrap=�6-   �� 5       �@��TextAlignment$ Center=�6.   �� 5       � ��
 �����6+   5      �� 5   
   " ��6#   .�5      ��  � ��$ 14(�6)   �� 5       � ��$	 200��6&   �� 5       � ��$ 0 20 0 0q�6'   �� 5       � �� �#3AB19B6+   �� 5       � �� �#FDFEFE6+   �� 5        �@�FocusVisualStyle 61   Z� �� 5!       � �� 5"      �� 5#      " ��6&   .R�5$      �� $��1q�6!   ���#49B7A3$ 20��5%   !   $��Center=�63   $��Center=�5&   !   #��z��5'   !   $ 15q�5(   !   $	��200��5)   !   $	��0 5q�5*   !   ._�5+      �� $��Center=�6/   $��Center=�6J   5,      5-      5/       50      P� 51       �@J�IsMouseOver$
	 True��61   . �52      ��  � �� �#33968563   �� 53       � ��
 �����63   54      P� 56       �@J�IsMouseCaptured$
	 True��65   . �57      ��  � �� �#2d7a6c63   �� 58       � ��
 �����63   59      5;      �� 5=   
   " ��6%   .�5>      ��  � ��$ 10 10q�6'   �� 5?       � ��$	 Top=�62   �� 5@       � ��$ Right=�64   �� 5A       � �� �#607D8B6+   �� 5B       � ��
 ���� 6+   �� 5C       � �� 5D      �� 5E      " ��6&   .R�5F      �� $��2q�6!   
������ $ 25��5G   !   $��Center=�63   $��Center=�5H   !   #��z��5I   !   $ 15q�5J   !   ._�5K      �� $��Center=�6/   $��Center=�6J   5L      5M      5O       5P      P� 5Q       �@J�IsMouseOver$
	 True��61   . �5R      ��  � z� 5S      �� 5T      $	
 1.1Q�6-   $	 1.1Q�6:   5V      5W      5Y      �� 5]   
   " ��6'   .�5^      ��  � �� �#9365176+   �� 5_       � �� �#ffbe396+   �� 5`       � ��$ 0q�60   �� 5a       � ��$ 20(�6)   �� 5b       � ��$ Center=�64   �� 5c       � ��$ Center=�62   �� 5d       � ��$ 
Montserrat)�6+   �� 5e       �@�Cursor$
 Hand��6'   �� 5f       � �� 5g      �� 5h      " ��6&   .R�5i      �� $��24��6!   $��24��6,   $ 12��5j   !   #��z��5k   !   ._�5l      �� $��Center=�6/   $��Center=�6J   5m      5n      5p       5q      P� 5r       �@J�IsMouseOver$
	 True��61   . �5s      ��  � ��
 �����63   �� 5t       � �� �#ffbe3963   5u      5w      �� 5y   
   " ��6$   8   .�5z      ��  � ��$ 18(�6)   �� 5{       � �� �#fe5e566+   �� 5|       � �� �#9637376+    5}      P� 5~       �@J�IsMouseOver$
	 True��61   . �5      ��  � ��
 �����63   �� 5�       � �� �#d32f2f63   5�      5�      �� 5�   
   " ��6'   8   .�5�      ��  � ��$ 18(�6)   �� 5�       � �� �#01ce4e6+   �� 5�       � �� �#0084216+    5�      P� 5�       �@J�IsMouseOver$
	 True��61   . �5�      ��  � ��
 �����63   �� 5�       � �� �#01ce4e63   5�      5�      �� 5�   
   " ��6,   .�5�      ��  � ��$ 14(�6)   �� 5�       � �� �#ff3a2a6+   �� 5�       � �� �#FDFEFE6+   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $��1q�6!   ���#ff3a2a$ 5��5�   !   $��Center=�62   $��Center=�5�   !   #��z��5�   !   $ 0q�5�   !   $��50��5�   !   $��25��5�   !   ._�5�      �� $��Center=�6/   $��Center=�6J   5�      5�      5�       5�      P� 5�       �@J�IsMouseOver$
	 True��61   . �5�      ��  � �� �#b2371763   �� 5�       � ��
 �����63   5�      P� 5�       �@J�IsMouseCaptured$
	 True��65   . �5�      ��  � �� �#5c140963   �� 5�       � ��
 �����63   5�      5�      �� 5�   
   " ��6%   8   .�5�      ��  � �� �#ff3a2a6+   �� 5�       � �� �#FDFEFE6+   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $��1q�6!   ���#ff3a2a$ 5��5�   !   $��Center=�62   $��Center=�5�   !   #��z��5�   !   $ 0q�5�   !   $��70��5�   !   $��30��5�   !   ._�5�      �� $��Center=�6/   $��Center=�6J   5�      5�      5�      5�      �� 5�   
   " ��6+   .�5�      ��  � ��$ 14(�6)   �� 5�       � �� �#3cd6396+   �� 5�       � �� �#FDFEFE6+   �� 5�       �@�FocusVisualStyle 61   Z� �� 5�       � �� 5�      �� 5�      " ��6&   .R�5�      �� $��1q�6!   ���#46fc43$ 5��5�   !   $��Center=�62   $��Center=�5�   !   #��z��5�   !   $ 0q�5�   !   $��50��5�   !   $��25��5�   !   ._�5�      �� $��Center=�6/   $��Center=�6J   5�      5�      5�       5�      P� 5�       �@J�IsMouseOver$
	 True��61   . �5�      ��  � �� �#1eb51b63   �� 5�       � ��
 �����63   5�      P� 5�       �@J�IsMouseCaptured$
	 True��65   . �5�      ��  � �� �#0e8f0b63   �� 5�       � ��
 �����63   5�      5�      �� 5�   
   " ��6!   .�5�      ��  � ��$ 14(�6)   �� 5�       � ��$ 1��6,   �� 5�       � ��$ 10 5 5 5q�6'   �� 5�       �@K�ZIndex$ 1��6-   �� 5�       � �� �#acb0af6+   5�      �� 5�   
   " ��6    .�5�      ��  � ��$ 14(�6)   �� 5�       � ��$ 1��6,   �� 5�       � ��$ 10 5 5 5q�6'   �� 5�       � �� �#8787876+   �� 5�       � ��
 ���� 6,   �� 5       � ��$ 0q�60   �� 5      � ��$ Center=�62   5     �� 5  
   " ��6)   .�5     ��  � ��$ 12(�6)   �� 5      � ��$ 
15 10 10 0q�6'   �� 5      � ��$
 Bold"�6+   5     �� 5  
   " ��6'   .�5     ��  � �� �#512da86+   �� 5      � �� �#4a148c6,   �� 5      � �� �#ffffff6+   �� 5      �@�FocusVisualStyle 61   Z� �� 5      � ��$ Center=�62   �� 5      � ��$ Center=�64   �� 5      � ��$ 30��6&   �� 5      � ��$	 1 0q�6'   �� 5      � �� 5     �� 5     " ��6&   .R�5     �� #��z��6!   $ 5��6K   $ 5q�6\   $��1q�6h   #��z��6|   ._�5     �� $��Center=�6/   $��Center=�6L   $��0 0 0 1q�6g   5     5     5      5     P� 5       �@J�IsMouseOver$
	 True��61   . �5!     ��  � �� �#673ab763   5"     5$     �� 5&  
   " ��6)   8   .�5'     ��  � �� �#d32f2f6+   �� 5(      � �� �#b71c1c6,    5)     P� 5*      �@J�IsMouseOver$
	 True��61   . �5+     ��  � �� �#f4433663   5,     5.     �� 50  
   " ��6.   8   .�51     ��  � �� �#1180306+   �� 52      � �� �#0644176,    53     P� 54      �@J�IsMouseOver$
	 True��61   . �55     ��  � �� �#3fb35f63   56     58     �� 5:  
   " ��6-   8   .�5;     ��  � �� �#d32f2f6+   �� 5<      � �� �#b71c1c6,    5=     P� 5>      �@J�IsMouseOver$
	 True��61   . �5?     ��  � �� �#f4433663   5@     5B     �� 5D  
   "  6'   .�5E     ��  � ��$ 12��6&   �� 5F      � ��$ 12��6'   �� 5G      � ��$ Center=�62   5I     �� 5M  
   "  6'   .�5N     ��  � ��
 ���� 6+   �� 5O      � ��
 ���� 6+   �� 5Q      � ��$ 0q�60   �� 5R       �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�69   �� 5S      � ��$
 true��6>   �� 5T      �@��PanningMode$
 Both=�69   �� 5U      �@��IsFlicksEnabled$ False��67   �� 5V      �@ AutoGenerateColumns$ False��64   �� 5W      �@ HeadersVisibility$ Column=�62   �� 5X      � ��$ 0 10 0 0q�6'   �� 5Y      �@ SelectionMode$ Single=�6.   �� 5Z      �@ SelectionUnit$ FullRow=�6.   �� 5[      �@ CanUserAddRows$ False��6/   �� 5\      �@ CanUserDeleteRows$ False��62   �� 5]      �@ CanUserResizeRows$ False��62   �� 5^      �@ CanUserReorderColumns$ False��66   �� 5_      � ��$ 14(�6)   �� 5`      �@ ColumnWidth$ * 6,   �� 5a      �@ CanUserAddRows$ False��6/   �� 5b      �@ GridLinesVisibility$
 None=�64   �� 5d      � �� 5e     �� 5f     "  6&   .R�5g     �� #��z��6!   #��z��6K   #��z��6w   # z��6�   $
 True��6�   ._�5h     �� $ DG_ScrollViewer��6+   $|�false��6D   ��5i  "   �� 5j  &   " ��66   .R�5k  *   �  5l  .   �� 5m  2   $
��Auto �6C   �� 5n  2   $��* �6C   �� 5o  2   $
��Auto �6C    5q  .   �� 5r  2   $
��Auto �6@   �� 5s  2   $��* �6@   �� 5t  2   $
��Auto �6@   .+�5v  .   �� #��Z 65   $|�false��6d   ��6v   C� *�� $" DataGridSelectAllButtonStyle��"  +y�6�   �� *HeadersVisibility+# Z # Z  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5w  .   $! PART_ColumnHeadersPresenter��6M   $��1��6r   y�6�   �� *HeadersVisibility+# Z # Z  �� "  �� 5x  .   $! PART_ScrollContentPresenter��6E   # z��6j   $��2��6�   $��1��6�   �� 5y  .   $ PART_VerticalScrollBar��68   $��2��6X   #  z 6h   $! Vertical=�6�   $��1��6�   ## z" 6  #y�z$ 6H  % 6�   �� *VerticalOffset+$& OneWay=� �� *TemplatedParent+6H  � 5z  .   $��1��63   $��2��6C    5{  2   �� 5|  6   ��6G   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5}  6   $��* �6G   .+�5  2   �� $ PART_HorizontalScrollBar��6<   $��1��6^   #  z' 6n   $! 
Horizontal=�6�   ## z( 6  #y�z) 6C  % 6�   �� *HorizontalOffset+$& OneWay=� �� *TemplatedParent+6C  5�  /   5�  +   5�  '   .��5�  "   �� # z 61   5�     5�     5�     5�      5�     ]� 5�     * 5�     �� 5�     + �@��
IsGrouping$
, true��6:   �� 5�     "+ �@%�IsVirtualizingWhenGrouping$, false��6\   ./�5�     ��  � ��$ false��6F   5�     5�     �� 5�  
   " n�61   .�5�     ��  � ��$ 8��6&   �� 5�      � ��
 ���� 6+   �� 5�      �@�Cursor$ SizeWE��6'   �� 5�      � �� 5�     �� 5�     " n�6&   .R�5�     �� 
�������$ 0q�64   $��0��6@   5�     5�     5�     �� 5�  
   " ��6   .�5�     ��  � �� 5�     �� 5�     " ��6&   .R�5�     � .+�5�     �� $- Border��6(   #��� ��68   $
 True��6y   � 5�     $. Arrow��6&   
���   �$��Right=�6B   $��8,8,3,3q�6^   $
/ 0.15Q�6o   0 �   ��� ��� ��� ��� $1 Uniform=�6�   $��Bottom=�6�   5�     2 5�     P� 5�      �@J�IsMouseOver$
	 True��6=   . �5�  "   �� $3 Border��6;   # � ��6O    � ��5�     P� 5�      � ��$
	 True��6;   . �5�  "   �� $3 Border��69   # � ��6M    � ��5�     P� 5�      � {�$	 False��6;   . �5�  "   �� $3 Arrow��6?    � y�$ 	Collapsed=�6R   5�     5�     5�     5�     �� 5�  
   "  6+   .�5�     ��  � ��
 ���� 6+   �� 5�      � �� 6+   ��  �� "  $4 
Foreground��� 5�      � ��$ Center=�62   �� 5�      �@�FocusVisualStyle 61   Z� �� 5�      � ��$
 15 0q�6'   �� 5�      � �� 5�     �� 5�     "  6&   .R�5�     �� 
������ $��0q�6;   $
 True��6O   ._�5�     �� # z 6/   5�     5�     5�     5�     �� 5�  
   "  63   .�5�     ��  � ��$ Center=�69   �� 5�      � ��$ Center=�6;   �� 5�      � �� 5�     �� 5�     $5 0.5,1&�6*   $6 0.5,0&�6;   .��5�     � $7 #01be98��6'   $8 0Q�67   � 5�     $7 #01987a��6'   $8 1Q�67   5�     5�     �� 5�      � ��$
 auto��6&   �� 5�      � ��
 �����6+   �� 5�      � ��$ 15(�6)   �� 5�      � ��$ 0q�6'   �� 5�      � ��$	 0 5q�6(   �� 5�      � �� 5�     �� 5�     "  6&   .R�5�     � .+�5�     	  #��z��69   #��z��6c   #��z��6�   #9 z��5�  9   #; z: 6a   #= z< 6�   # z��6�   #? z> 5�  9   #A z@ 6i   #C zB 6�   $ 5��6�   $��40��6�   ._�5�  "   �� #��z��63   $
��True��6v   # z 6�   #��z��6�   5�     n� 5�     $D PART_LeftHeaderGripper��6$   $
��Left=�6D   8��  6_   n� 5�     $D PART_RightHeaderGripper��6$   $��Right=�6E   8�� 6a   5�     5�     5�     5�     �� 5�  
   "  6*   .�5�     ��  � �� �#f3f3f36+   �� 5�      � �� �#01987a6+   �� 5�      � ��$ 0 4 0 0q�6'   �� 5�      �@J�SnapsToDevicePixels$
 true��64   �� 5�      �@=�ErrorTemplate 69   Z� �� 5�      �@ ValidationErrorTemplate 5�     �� 5�     .R�5�     �� 
���  ��$��2,0,0,0q�65   $��!��6F   $��Center=�6O   5�     5�     �� 5�      � �� 5�     �� 5�     "  6&   .R�5�     �� $E 
DGR_Border��6!   $	 0 8q�65   #��z��6C   $ 5��6m   $��0q�6~   $
 True��6�   ._�5�     
   5�  "   �� 5�  &   $
��Auto �67   �� 5   &   $��* �67    5  "   �� 5  &   $��* �64   �� 5  &   $
��Auto �64   .+�5  "     $��1��69   #��zF 6I   # z 6s     5  "   $��1��6;   $��1��6K   #y�zG 6o  H 6X   �� *AreRowDetailsFrozen+# ZI # ZJ  �� "  6o    5  "   $��2��64   $H Vertical=�6E   y�6�   �� *HeadersVisibility+# ZK # Z  �� "  5	     5
     5     5      5     P� 5      �@J�IsMouseOver$
	 True��61   . �5     ��  � �� �#01d4a963   �� 5      � ��
 �����63   5     5$     5+     5,     