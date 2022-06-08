# Camera rotation

It is necessary to develop a controller for the camera that allows you to change its position. Required camera operation modes:

- Automatic – the camera smoothly rotates around the house counterclockwise, making a turn every 30 seconds, looking constantly at the house;
- Manual – Use the left and right buttons to move the camera around the house while keeping the focus on the house.

Automatic mode is implemented using the DOTween animation engine.

In manual mode, try to make arrivals, i.e. a smooth stop of movement (as on rails). The manual mode is implemented by changing the position in the Update method.