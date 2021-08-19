import matplotlib.pyplot as plt
import numpy as np
import math

# Based on SpringProblem_3.pdf

A = 0.02 #m
m = 0.05 #kg
omega = 10 # rads/s

# Ak = A(ω^2)*m
# k = (ω^2)*m
k = (omega**2)*m  #5.00 kg/s^2

# T = 2π * sqrt(m/k) = 2πω
T = 2*math.pi * omega #0.628s
f = 1/T

# vMax = Aω
vMax = A*omega

# aMax = A(ω^2) = A(k/m)
aMax = A * (k/m)

# Displacement
x = np.linspace(0, 5, 100)
y = A*np.cos(omega*x)  # X(t) = A*cos(ωt)
# y = A*np.cos(omega*x) # X(t) = A*cos((2πt)/T)
plt.subplot(3,1,1)
plt.plot(x, y)
plt.plot(x, y, color='r')
plt.xlim([0, 3])
plt.ylim([-A-0.02, A+0.02])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Position (m)")
#plt.title("Displacement", fontdict={"family": "serif", "size": 9})

# Velocity
x = np.linspace(0, 5, 100)
y = -vMax*np.sin(omega*x)  # V(t) = -vMax*sin(ωt)
# y = -vMax*np.sin((2*math.pi*x)/T) # V(t) = -vMax*sin((2πt)/T)
plt.subplot(3,1,2)
plt.plot(x, y)
plt.plot(x, y, color='g')
plt.xlim([0, 3])
plt.ylim([-vMax-0.1, vMax+0.1])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Velocity (m/s)")
#plt.title("Velocity", fontdict={"family": "serif", "size": 9})

# Acceleration
x = np.linspace(0, 5, 100)
y = -aMax*np.cos(omega*x)  # a(t) = -aMax*sin(ωt)
plt.subplot(3,1,3)
plt.plot(x, y)
plt.plot(x, y, color='b')
plt.xlim([0, 3])
plt.ylim([-aMax-0.5, aMax+0.5])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Acceleration (m/s^2)")
#plt.title("Acceleration", fontdict={"family": "serif", "size": 9})

plt.show()