   M S B A M L   `   `   `  ����G  CLandConquest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LandConquest.FormsLandConquest.Forms  5   	   /    )LandConquest.Forms.CastleManagementWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LandConquest.Forms     5   	   -   5          � WindowStyle$
  None=�5       � 
ResizeMode$ NoResize=�6-   $	��450��5   	   $	��600��6   .��5
      �� ���	#FF392018$��3q�6%   $
��Auto��69   $
��Auto��6G   ._�5   
   � .+�5      �� -   5         ��Name$ castleMenuGridBorder��5      ���	#FF48291F$��3q�6K   $
��Auto��6_   $
��Auto��6l   $	��Top=�6z   $��288,110,32,0q�6�   ._�5      � -   5         �Name$ castleMenuGrid��5      $y�Visible=�6/   $	��210��6D   $	��Top=�6Q   $
��Auto��6i   .+�5      �� -   5         ��Name$ buttonSendResources��5      $��Send resources��6:   $��20(�6S   ���	#FFDFC58E$��Book Antiqua)�6�   $��10,10,9.6,0q�6�   $��44��6�   $	��Top=�6�   ��6a   Z� ��5      �� 5       �� ImageSource$A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6)   5      �� 5      -   5        $ buttonUpgrade��5      $��Upgrade castle��64   $��20(�6M   $��Center=�6[   $��44��6}   $��10,59,9.6,0q�6�   $	��Top=�6�   ���	#FFDFC58E$��Book Antiqua)�6�   ��6�   Z� ��5      �� 5      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6)   5      �� 5      -   5        $ buttonSendForces��5      $��Send forces��67   $��20(�6M   $��Center=�6[   $��44��6}   $��10,108,10,0q�6�   $	��Top=�6�   ���	#FFDFC58E$��Book Antiqua)�6�   ��6�   Z� ��5      �� 5      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6)   5      �� 5      -   5        $ buttonReturnForces��5      $��Return forces��69   $��20(�6Q   $��Center=�6_   $��10,157,9.6,0q�6�   ���	#FFDFC58E$��Book Antiqua)�6�   $��44��6�   $	��Top=�6�   ��6�   Z� ��5      �� 5       $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6)   5"      ��5#      �� 5$      $5 //LandConquest;component/Pictures/background.jpg��6%   5&      5'      �� 5+      $
��Left=�6   $	��175��6/   $��	25,30,0,0q�6<   $	��Top=�6O   $	��187��6g   $;��5/LandConquest;component/Pictures/Buildings/Castle.png��6s   �� 5,      $��Current lvl:��6   $��Right=�6+   $��20(�6N   $
��Bold"�6\   $
��Left=�6n   $��	0,210,0,0q�6�   $	��Top=�6�   $	��239��6�   $��Trebuchet MS)�6�   �� 5-      $��Current defence bonus:��6   $��Right=�65   $��18(�6X   $
��Bold"�6f   $
��Left=�6x   $��	0,259,0,0q�6�   $	��Top=�6�   $	��239��6�   $��Trebuchet MS)�6�   �� 5.      $��Resources to upgrade:��6   $��Right=�64   $��20(�6W   $
��Bold"�6e   $
��Left=�6w   $��	0,307,0,0q�6�   $	��Top=�6�   $	��239��6�   $��Trebuchet MS)�6�   �� 5/      $��	Garrison:��6   $��Right=�6(   $��20(�6K   $
��Bold"�6Y   $
��Left=�6k   $��	0,358,0,0q�6�   $	��Top=�6�   $	��115��6�   $��Trebuchet MS)�6�   �� 50      $��/��6   $��Center=�6    $��20(�6D   $
��Bold"�6R   $
��Left=�6d   $��160,358,0,0q�6   $	��Top=�6�   $��19��6�   $��Trebuchet MS)�6�   �� 52      -   5         ��Name$ labelGarrisonReal��52      $
��real��60   $��Center=�6?   $��20(�6c   $
��Bold"�6q   $��0,358,433.6,0q�6�   $	��Top=�6�   $��Right=�6�   $��45��6�   $��Trebuchet MS)�6�   �� 53      -	   5        $ labelGarrisonMax��53      $	��max��6/   $��Center=�6=   $��20(�6a   $
��Bold"�6o   $��0,358,361,0q�6�   $	��Top=�6�   $��Right=�6�   $��60��6�   $��Trebuchet MS)�6�   �� 55      -
   5        $ buttonClose��55      $��20��6*   $	��Top=�66   ���	#FFDFC58E$
��Left=�6|   $��	573,0,0,0q�6�   $��21��6�   ��6N   Z� ��56      �� 57      $6 0/LandConquest;component/Pictures/buttonCross.jpg��6!   59      �� 5:      -   5        $ buttonShowMenu��5:      $��Management menu��6-   $��24(�6G   $
��Bold"�6U   $��Center=�6g   $
��Left=�6�   $��66��6�   $��
288,46,0,0q�6�   $	��Top=�6�   $	��274��6�   ���	#FFDFC58E$��Book Antiqua)�6  ��6�   Z� ��5;      �� 5<      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6!   5>      ��5A      �� 5B      $# /Pictures/background_pale.jpg��6    j� Stretch$ UniformToFill=�6I   5D      5E      5F      