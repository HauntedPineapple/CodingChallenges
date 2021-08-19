import matplotlib.pyplot as plt
import numpy as np
import math

# Based on SpringProblem_2.pdf

m = 0.5  # kg
T = 4
f = 1/T
vMax = 2

# ω = 2πf
omega = 2*math.pi*f

# vMax = Aω
# vMax/ω = A
A = vMax/omega  # 1.27m

# aMax = A(ω^2) = A(k/m)
aMax = A*(omega**2)

# Ak = A(ω^2)*m
# k = (ω^2)*m
k = (omega**2)*m  # 1.23 N/m

# Displacement
x = np.linspace(0, 10, 100)
y = A*np.cos(omega*x)  # X(t) = A*cos(ωt)
# y = A*np.cos(omega*x) # X(t) = A*cos((2πt)/T)
plt.subplot(3, 1, 1)
plt.plot(x, y, color='r')
plt.xlim([0, 8])
plt.ylim([-A-0.5, A+0.5])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Position (m)")
#plt.title("Displacement", fontdict={"family": "serif", "size": 9})

# Velocity
x = np.linspace(0, 10, 100)
y = -vMax*np.sin(omega*x)  # V(t) = -vMax*sin(ωt)
# y = -vMax*np.sin((2*math.pi*x)/T) # V(t) = -vMax*sin((2πt)/T)
plt.subplot(3, 1, 2)
plt.plot(x, y, color='g')
plt.xlim([0, 8])
plt.ylim([-vMax-0.5, vMax+0.5])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Velocity (m/s)")
#plt.title("Velocity", fontdict={"family": "serif", "size": 9})

# Acceleration
x = np.linspace(0, 10, 100)
y = -aMax*np.cos(omega*x)  # a(t) = -aMax*sin(ωt)
plt.subplot(3, 1, 3)
plt.plot(x, y, color='b')
plt.xlim([0, 8])
plt.ylim([-aMax-0.5, aMax+0.5])
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Acceleration (m/s^2)")
#plt.title("Acceleration", fontdict={"family": "serif", "size": 9})

plt.show()

# Energy
x = np.array([0, 10])
# E(t) = K(t) + U(t) = 1/2 * k(A^2)
# K(t) = 1/2 * m(v(t)^2) v(t) = -vMax*sin(ωt)
# U(t) = 1/2 * k * (t^2)
y = np.array([1/2 * (k * (A**2)), 1/2 * (k * (A**2))])
plt.subplot(3, 1, 1)
plt.plot(x, y, color='r')
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Energy (J)")

# Kinetic (K)
x = np.linspace(0, 9, 100)
y = 1/2 * (m*np.exp((-vMax*np.sin(omega*x)**2)))  # K(x) = 1/2 * m(v(x)^2)
plt.subplot(3, 1, 2)
plt.plot(x, y, color='g')
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Kinetic Energy (J)")

# Potential (U)
x = np.linspace(0, 9, 100)
y = 1/2 * k * np.exp(x**2)  # U(x) = 1/2 * k(x^2)
plt.subplot(3, 1, 3)
plt.plot(x, y, color='b')
plt.grid()
plt.xlabel("Time (s)")
plt.ylabel("Potential Energy (J)")

# plt.show()
