   M S B A M L   `   `   `  ����E  AMainPlugin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MainPlugin.AutoClicker.ModesMainPlugin.AutoClicker.Modes  5      F BMyFunctions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctionsMyFunctions.ControlsWPF 5      4    .MainPlugin.AutoClicker.Modes.ClicksProgramMode   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:MainPlugin.AutoClicker.Modes     5      Jmyf:clr-namespace:MyFunctions.ControlsWPF;assembly=MyFunctions     5      .��5	      ��   �� Orientation$  Vertical=�6   .+�5
   
   �� -   5         ��Name$ BT_OpenProgram��5
      $#��Ouvrir un programme de clicks��6)   $��16(�6Q   ���#DDDDDD
���   �6�   �� 5   
   
���   �$��1q�6%   $��0,10,0,0q�69   ._�5      �� $  Vertical=�6   .+�5      �� $  
Horizontal=�6   $	��0,1q�66   $��Center=�6C   .+�5      �� -   5        $ BT_AddPoints��5      $��Ajouter un point de click��63   $��14(�6W   ���#DDDDDD
���   �6�   �� 5      -   5        $ BT_RemovePoint��5      $��	Supprimer��65   $��14(�6I   ���#DDDDDD$��5,0,0,0q�6l   
���   �6�   �� 5      -   5        $ BT_VisualisePoint��5      $��
Visualiser��68   $��14(�6M   ���#DDDDDD$��5,0,0,0q�6p   
���   �6�   5      �� 5      -   5         ��Name$ 	LV_Points��5      $��14(�6.   $��Visible=�6<   $	��223��6o   �� 5      $  
Horizontal=�6   $��Center=�66   .+�5      �� $$��Intervalle (en milliseconde) :��6   $��14(�6E   
���   �6S   +  %MyFunctions.ControlsWPF.NumericUpDown  5      -   5          Name$ NUD_Interval��5   (   
   Min$ 1Q�6>   
   Max$ 1E+30Q�6F      Value$
 1000Q�6R   5      �� 5      $  
Horizontal=�6   $��Center=�66   $��0,5,0,0q�6S   .+�5      �� $��Nombre de répétitions :��6   $��14(�6>   
���   �6L     5      -   5        $ 
NUD_Repeat��5   (   $ 1Q�6<   $ 10Q�6D   $ 1Q�6M   5      5      5      �� 5   
   -   5        $ BT_SaveProgram��5      $(��"Enregistrer un programme de clicks��6)   $��16(�6V   ���#DDDDDD$��0,10,0,2q�6y   
���   �6�   5      5      