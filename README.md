# SchlickCurve
Unity implementation of a generalization of Schlick’s 'bias' and 'gain' functions


## Paper 

This is an implementation of ["A Convenient Generalization of Schlick’s Bias and Gain Functions"](https://arxiv.org/pdf/2010.09714.pdf) by Jon Barron.  Please see the paper for details on the math.


# Usage

```
var eased = Schlick.Curve(valueToEase, slope, threshold);
```

Both `float` and `double` versions are provided.


## Demo Scene

Open the scene `Schlick Curve Demo` to see a simple example.  
Select the `Schlick Curve Test` object in the scene heirarchy - the controls for the demo are on its inspector. You can modify the `slope` and `threshold` of the curve function here.  

Enter play mode to see it work.

The white cursor object will show you an unfiltered `sin(time)` value applied to position interpolation.

The light blue cursor object will show you how filtering the `sin(time)` value using the curve function changes the results.


