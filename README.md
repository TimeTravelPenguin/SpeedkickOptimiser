# SpeedkickOptimiser
Optimisation tool for speedkicks in Super Mario 64 TASing

![alt text](https://imgur.com/Yt6DGQx "Video example")

This tool helps to find angles suitable for speedkick similar to the current input angle,
and allows you to narrow it down to those of larger analogue stick magnitudes. Whether you need speed of precice angle, this tool will help.

![alt text](https://i.imgur.com/sD1SlQ7.png "Preview of the tool in use")

## Understanding the tool

As you know, the TAS Input Tool, as seen below, uses a integer coordinate system to define analgue positions. That is, a specific (x, y) coordinate
is used to determine where the stick is moved to. This (x, y) coordinate is inputted into the x and y number boxes in the optimization tool
as unsigned integers (the sign doesn't effect the result - you may ne to use a little intuition). Once the input it selected, you need to choose
your degree of range that you wish to look for suitible angles in. By default this is 2 degrees, which means if you take your input vector,
and rotate it 2 degrees clockwise and anticlockwise, you create a region of space to which the program looks in for appropriate angles.
Simply hitting calculate runs the tool, and displays to the datagrid.

![alt text](https://i.imgur.com/QBQkn24.png "TAS Input Tool in Mupen64")

Once the data is outputted to the grid, the next part is understanding the data. The `Raw Stick X` and `Raw Stick Y` show the coordinate needed
to be put into the TAS tool to get the results shown rightward. The remaining results are results made with respect to the processed coordinates.
As you may or may not know, SM64 takes your input coordinates, and does some stuff to it depending of the magnitudes of the values.
Simply put, the remaining information are NOT the information for the RAW inputs being displayed.

As an example, in the image at the top of this file, the top result yields the raw values (35, 44). This results in a `Stick Mag` of 47.80167.
However, if you calculate `sqrt((35 * 35) + (44 * 44))`, you are given 56.22277 as a result. That is because the `Stick Mag` is **NOT** the RAW input's
magnitude (same goes for the remaining columns). So, althought (54, 0) and (0, 54) allow you to speedkick, the actual magnitude you need to look for
when optimising speedkicks is 48. So, be sure to remember that! (54, 0) has a RAW magnitude of 54, but a processed magnitude of 48!
