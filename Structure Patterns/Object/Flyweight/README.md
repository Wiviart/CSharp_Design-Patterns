# FLYWEIGHT PATTERN

## Intent
Use sharing to support large numbers of fine-grained objects efficiently

## Applicability
The Flyweight pattern's effectiveness depends heavily on how and where it's
used. Apply the Flyweight pattern when all of the following are true:

• An application uses a large number of objects.

• Storage costs are high because of the sheer quantity of objects.

• Most object state canbe made extrinsic.

• Many groups of objects may be replaced by relatively few shared objects
once extrinsic state isremoved.

• The application doesn't depend on object identity. Since flyweight objects
may be shared, identity tests will return true for conceptually distinct objects.

![alt text](image.png)

![alt text](image-1.png)