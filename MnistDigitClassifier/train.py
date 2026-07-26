"""
train.py
--------
End-to-end training script for the MNIST handwritten digit classifier.

What this script does:
  1. Downloads the MNIST dataset (60,000 training images, 10,000 test images).
  2. Builds the CNN defined in model.py.
  3. Trains the model for a few epochs (full passes over the training data).
  4. Evaluates accuracy on the held-out test set.
  5. Saves the trained model weights to mnist_cnn.pth.

Run it with:
    python train.py
"""

import torch
import torch.nn as nn
import torch.optim as optim
from torch.utils.data import DataLoader
from torchvision import datasets, transforms

from model import SimpleCNN

# --- Configuration -----------------------------------------------------
BATCH_SIZE = 64
EPOCHS = 5
LEARNING_RATE = 0.001
DATA_DIR = "./data"
MODEL_OUT = "mnist_cnn.pth"


def get_data_loaders():
    # Convert images to tensors and normalize pixel values using
    # MNIST's known mean/std, which helps the model train faster and more stably.
    transform = transforms.Compose([
        transforms.ToTensor(),
        transforms.Normalize((0.1307,), (0.3081,)),
    ])

    train_dataset = datasets.MNIST(root=DATA_DIR, train=True, download=True, transform=transform)
    test_dataset = datasets.MNIST(root=DATA_DIR, train=False, download=True, transform=transform)

    train_loader = DataLoader(train_dataset, batch_size=BATCH_SIZE, shuffle=True)
    test_loader = DataLoader(test_dataset, batch_size=BATCH_SIZE, shuffle=False)

    return train_loader, test_loader


def train_one_epoch(model, device, train_loader, optimizer, criterion, epoch):
    model.train()
    running_loss = 0.0

    for batch_idx, (images, labels) in enumerate(train_loader):
        images, labels = images.to(device), labels.to(device)

        optimizer.zero_grad()          # Reset gradients from the previous step
        outputs = model(images)        # Forward pass: get predictions
        loss = criterion(outputs, labels)  # Compare predictions to true labels
        loss.backward()                # Backward pass: compute gradients
        optimizer.step()               # Update model weights

        running_loss += loss.item()

        if batch_idx % 200 == 0:
            print(f"Epoch {epoch} | Batch {batch_idx}/{len(train_loader)} | Loss: {loss.item():.4f}")

    avg_loss = running_loss / len(train_loader)
    print(f"Epoch {epoch} finished. Average training loss: {avg_loss:.4f}")


def evaluate(model, device, test_loader):
    model.eval()
    correct = 0
    total = 0

    with torch.no_grad():  # No need to track gradients during evaluation
        for images, labels in test_loader:
            images, labels = images.to(device), labels.to(device)
            outputs = model(images)
            predicted = outputs.argmax(dim=1)  # Pick the class with the highest score

            correct += (predicted == labels).sum().item()
            total += labels.size(0)

    accuracy = 100.0 * correct / total
    print(f"Test accuracy: {accuracy:.2f}% ({correct}/{total})")
    return accuracy


def main():
    device = torch.device("cuda" if torch.cuda.is_available() else "cpu")
    print(f"Using device: {device}")

    train_loader, test_loader = get_data_loaders()

    model = SimpleCNN().to(device)
    optimizer = optim.Adam(model.parameters(), lr=LEARNING_RATE)
    criterion = nn.CrossEntropyLoss()

    for epoch in range(1, EPOCHS + 1):
        train_one_epoch(model, device, train_loader, optimizer, criterion, epoch)
        evaluate(model, device, test_loader)

    torch.save(model.state_dict(), MODEL_OUT)
    print(f"Model saved to {MODEL_OUT}")


if __name__ == "__main__":
    main()
