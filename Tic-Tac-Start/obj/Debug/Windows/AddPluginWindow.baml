   M S B A M L   `   `   `  ����F  BMyFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctionsMyFunctions.ControlsWPF  5   	   H DTic-Tac-Start, Version=2.3.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Tic_Tac_StartTic_Tac_Start 5   	   #   Tic_Tac_Start.AddPluginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Jmyf:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctions     5   	   -localclr-namespace:Tic_Tac_Start     5   	     � Title$  Nouveau plugin��5	   	      WinStyle#���   5
   	    � WindowStartupLocation$ CenterScreen=�6,    � 	Resources 5       �� 
TargetType �� Property �� Value��%<  '��       '�� �     �� 5   
   " ��6   .�5      ��  � ��$
 0, 5q�6'   �� 5       � ��
 �����6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ Right=�6;   5      �� 5   
   " ��6   .�5      ��  � ��$ 16(�6)   �� 5       � ��$	 0,5q�6'   5      5      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
      Tic_Tac_Start.WindowHeader  �� 5   
   $ Vertical=�6   $��10q�6,   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5      �� $ Vertical=�6   $��Center=�64   $��0��6Q   .+�5       �� $��Chemin du plugin (DLL) :��6   �� 5!      $��Titre de l'action :��6   �� 5"      $��Classe de la fonction :��6   �� 5#      $��Nom de la fonction :��6   �� 5$      $ ��Fenêtre de paramètrage :��6   5%      �� 5&      $ Vertical=�6   $��Center=�64   $��1��6Q   .+�5'      �� $ 
Horizontal=�6!   .+�5(      �� -   5         ��Name$ 
TB_DllPath��5(   "   	 �� 
IsReadOnly	 . $	��211��6H   �� 5)      -   5        
 ��Name$
 BT_ChooseDLL��5)   !   $	��...��67     SecondaryButtonStyle#���  6E   $
��5, 0q�6t   6�   5*      �� 5+      $ 
Horizontal=�6!   $
��0,10q�6:   .+�5,      '   !MyFunctions.ControlsWPF.MyTextBox  -   5          Name$ TB_ActionName��5,   (      DefaultText$ Titre en Français��6?   $	��117��6_   $	��5,0q�6k     5-      -   5        $ TB_ActionName_English��5-   (   $ Titre en Anglais��6G   $	��117��6f   $	��5,0q�6r   5.      �� 5/      -   5        $ TB_MethodClass��5/      $
��0, 9q�66   �� 50      -   5        $ TB_MethodName��50      $
��0, 7q�65   �� 51      -   5        $ TB_ParamsDialog��51      $
��0, 9q�67   52      53      �� 54      -   5        $
 BT_AddPlugin��54      $��Ajouter le plugin��6+   $��20q�6G   6S   55      56      57      