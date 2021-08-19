import matplotlib.pyplot as plt
import numpy as np
import math

# Based on SpringProblem_1.pdf

m = 0.7  # kg
k = 21   # N/m
A = 0.15  # m

# T = 2π * sqrt(m/k)
T = (2 * math.pi) * math.sqrt(m/k)
# f = 1/T
f = 1/T
# ω = 2πf
omega = 2*math.pi*f
# vMax = Aω
vMax = A * omega
# aMax = A(ω^2) = A(k/m)
aMax = A*(omega**2)

# Displacement
x = np.linspace(0, 5, 100)
y = A*np.cos(omega*x)  # X(t) = A*cos(ωt)
# y = A*np.cos(omega*x) # X(t) = A*cos((2πt)/T)
plt.subplot(3, 1, 1)
plt.plot(x, y)
plt.plot(x, y, color='r')
plt.xlim([0, 5])
plt.ylim([-A-0.1, A+0.1])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Position (m)")
#plt.title("Displacement", fontdict={"family": "serif", "size": 9})

# Velocity
x = np.linspace(0, 5, 100)
y = -vMax*np.sin(omega*x)  # V(t) = -vMax*sin(ωt)
# y = -vMax*np.sin((2*math.pi*x)/T) # V(t) = -vMax*sin((2πt)/T)
plt.subplot(3, 1, 2)
plt.plot(x, y)
plt.plot(x, y, color='g')
plt.xlim([0, 5])
plt.ylim([-vMax-0.5, vMax+0.5])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Velocity (m/s)")
#plt.title("Velocity", fontdict={"family": "serif", "size": 9})

# Acceleration
x = np.linspace(0, 5, 100)
y = -aMax*np.cos(omega*x)  # a(t) = -aMax*sin(ωt)
plt.subplot(3, 1, 3)
plt.plot(x, y)
plt.plot(x, y, color='b')
plt.xlim([0, 5])
plt.ylim([-aMax-0.5, aMax+0.5])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Acceleration (m/s^2)")
#plt.title("Acceleration", fontdict={"family": "serif", "size": 9})

plt.show()
