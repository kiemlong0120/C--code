   M S B A M L   `   `   `  ����T  PGauRedAutoFishingAvatarHD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GauRedAutoFishingAvatarHDGauRedAutoFishingAvatarHD  5   	   *    $GauRedAutoFishingAvatarHD.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:GauRedAutoFishingAvatarHD     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5	   	     � WindowStyle$
  None=�5
   	    � WindowState$ Normal=�5   	    � 
ResizeMode$ 	CanResize=�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   $
��1200��5   	   $	��800��6    � WindowStartupLocation$ CenterScreen=�5   	   ��5   	   ��  �� Source# Zo� �� Path$ Width���5   	   �� # Zo�$ Height�'  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
   	   CaptionHeight$	 48Q�6   .��5      � -   5        
 �Name$	
 app��5      $��Center=�5      .+�5   
   � -   5        $
 header��5      $	��Top=�5      
���  ��.+�5       (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ PrimaryDark=�5!      $��50��5"      $	��Top=�5#      
���  ��   CornerRadius$ 5��5$      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�5%      .��5'      ��  �� Orientation$ 
Horizontal=�5(      .+�5)      d� $��16 0 0 0q�5*       ' #MaterialDesignHamburgerToggleButton#���  5+      �� 5,      $��	400,0,0,0q�5-      
���   �$��Caro Game by GAURED��5/      $��30(�50      $
��Bold"�51      52      53      � 56      -   5        $
 navigationBar��56      .+�57      �� -   5         ��Name$ ControlWindow��57      $��50��58         IsHitTestVisibleInChrome . $ 
Horizontal=�5:      $��Right=�5;      $��Center=�5<      $��0 0 10 0q�5=      .+�5?      �� -   5         ��Name$
 btn1��5?      $��0��5A      $��0��5B      {�.  ��5@      0  *MaterialDesignThemes.Wpf.PackIconExtension  *RhombusOutline+5C      �� 5E      -   5        $
 btn2��5E      $��0��5G      $��0��5H      {�.  ��5F        *SquareOutline+5I      �� 5K      -   5        $ MinimizeButton��5K      
���  ��$��Right=�5N      $��Center=�5O      $��30��5P      $��25��5Q      
���  ��$��0 0 0 0q�5S       � ToolTip$ Minimize��5V      $��0,12,0,12.6q�5W   J   ��6     *TriangleOutline+6J   �� 5Y      -   5        $ MaximizeButton��5Y      
���  ��$��Right=�5\      $��Center=�5]      $��30��5^      $��25��5_      
���  ��$��0 0 0 0q�5a      $ Maximize��5d      ��5e        *SquareOutline+�� 5g      -	   5        $ CloseButton��5g      
���  ��$��Right=�5j      $��Center=�5k      $��30��5l      $��25��5m      
���  ��$��0 0 0 0q�5o      $ Close��5r      ��5s        *CircleOutline+5v      5w      5x      � 5{   
   -
   5        $

 body��5{      $��0,50,0,0q�6   .+�5}      �� $��Center=�5~      $	��700��5      $	��700��5�      
����� �5�      �� 5�      $
��Left=�6   $	��224��5�      
�������$��966,10,10,10q�5�      5�      �� 5�      
�������$��10,10,966,10q�5�   "   5�      5�      5�      