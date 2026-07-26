"""
model.py
--------
Defines a small Convolutional Neural Network (CNN) for classifying
handwritten digits (0-9) from the MNIST dataset.

If you're new to neural networks, here's the mental model:
  - Convolution layers scan the image with small filters to detect
    patterns like edges, curves, and loops (the strokes that make up digits).
  - Pooling layers shrink the image while keeping the important features,
    which reduces computation and adds a bit of tolerance to shifts/noise.
  - Fully connected (Linear) layers combine those detected features to
    make the final decision: "which digit (0-9) is this?"
"""

import torch.nn as nn
import torch.nn.functional as F


class SimpleCNN(nn.Module):
    def __init__(self):
        super().__init__()

        # Input: 1 channel (grayscale), 28x28 pixel MNIST image
        # Conv layer 1: learns 16 different 3x3 filters (feature detectors)
        self.conv1 = nn.Conv2d(in_channels=1, out_channels=16, kernel_size=3, padding=1)

        # Conv layer 2: learns 32 filters, built on top of conv1's output
        self.conv2 = nn.Conv2d(in_channels=16, out_channels=32, kernel_size=3, padding=1)

        # Pooling layer: shrinks the image by taking the max value in each 2x2 block
        self.pool = nn.MaxPool2d(kernel_size=2, stride=2)

        # After 2 pooling operations, a 28x28 image becomes 7x7,
        # and we have 32 channels -> 32 * 7 * 7 values to feed into the classifier
        self.fc1 = nn.Linear(32 * 7 * 7, 128)
        self.fc2 = nn.Linear(128, 10)  # 10 output classes: digits 0-9

        # Dropout randomly "turns off" neurons during training to reduce overfitting
        self.dropout = nn.Dropout(0.25)

    def forward(self, x):
        # Block 1: convolution -> activation -> pooling
        x = self.pool(F.relu(self.conv1(x)))   # 28x28 -> 14x14

        # Block 2: convolution -> activation -> pooling
        x = self.pool(F.relu(self.conv2(x)))   # 14x14 -> 7x7

        # Flatten the 3D feature maps into a 1D vector per image
        x = x.view(x.size(0), -1)

        x = F.relu(self.fc1(x))
        x = self.dropout(x)
        x = self.fc2(x)  # Raw scores ("logits") for each of the 10 digit classes

        return x
