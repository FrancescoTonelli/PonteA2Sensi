   M S B A M L   `   `   `  ����N  JAutostradeSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AutostradeSimulatorAutostradeSimulator  5   	   $    AutostradeSimulator.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:AutostradeSimulator     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ 	imgSfondo��5
      $
��Left=�6#   $	��399��6>   $��	43,10,0,0q�6K   $	��Top=�6^   $	��702��6v   $��
sfondo.png��6�   �� 5   
   -   5        $ 	imgStopSx��5      $
��Left=�6#   $��51��6>   $��218,221,0,0q�6J   $	��Top=�6_   $��53��6w   $��stop.PNG��6�   �� 5   
   -   5        $ 	imgStopDx��5      $
��Left=�6#   $��51��6>   $��
573,64,0,0q�6J   $	��Top=�6^   $��53��6v   $��stop.PNG��6�   �� 5   
   -   5        $ imgSx1��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -   5        $ imgSx2��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -   5        $ imgSx3��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -   5        $ imgSx4��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -   5        $ imgSx5��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -	   5        $ imgSx6��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -
   5        $ imgSx7��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -   5        $ imgSx8��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -   5        $ imgSx9��5      $
��Left=�6    $��50��6;   $��
86,240,0,0q�6G   $	��Top=�6[   $	��100��6s   $��macchinaSx.png��6   �� 5   
   -   5        $ imgSx10��5      $
��Left=�6!   $��50��6<   $��
86,240,0,0q�6H   $	��Top=�6\   $	��100��6t   $��macchinaSx.png��6�   �� 5   
   -   5        $ imgDx1��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5   
   -   5        $ imgDx2��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5   
   -   5        $ imgDx3��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5   
   -   5        $ imgDx4��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5   
   -   5        $ imgDx5��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5   
   -   5        $ imgDx6��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5   
   -   5        $ imgDx7��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5   
   -   5        $ imgDx8��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5   
   -   5        $ imgDx9��5      $
��Left=�6    $��50��6;   $��627,136,0,0q�6G   $	��Top=�6\   $	��100��6t   $��macchinaDx.png��6�   �� 5    
   -   5        $ imgDx10��5       $
��Left=�6!   $��50��6<   $��627,136,0,0q�6H   $	��Top=�6]   $	��100��6u   $��macchinaDx.png��6�   �� 5!   
   -   5         ��Name$ lblDx��5!      $�� ��6   $
��Left=�6*   $��
608,33,0,0q�6E   $	��Top=�6Y   $	��119��6q   �� 5"   
   -   5        $ lblSx��5"      $�� ��6   $
��Left=�6*   $��
67,351,0,0q�6E   $	��Top=�6Y   $	��119��6q   5$      5%      