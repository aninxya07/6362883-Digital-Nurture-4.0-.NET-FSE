# Kafka Terminal-Based Chat Application

This is a terminal-based simulation of a simple chat application using **Apache Kafka** as the streaming platform. It demonstrates the producer-consumer model where chat messages are produced by one terminal and consumed in real-time by another, using Kafka's publish-subscribe mechanism.
  

## 🛠️ Tech Stack


-  **Apache Kafka**

-  **Zookeeper**

-  **Docker**

-  **Bitnami Kafka & Zookeeper Images**

-  **Command Line**

---

## ⚙️ Kafka Architecture Concepts Used

  

-  **Topics:** Logical channel where messages are published and consumed.

-  **Partitions:** Each topic can have one or more partitions (used 1 in this demo).

-  **Brokers:** Kafka servers that manage data and handle requests.

-  **Producers & Consumers:** Terminals acting as chat message senders and receivers.

---  

<br/>

## 🚀 Setup Instructions

  

### 1. Clone or Create the Docker Setup

  
docker-compose.yml

```bash
version: '3'

services:
	zookeeper:
		image: bitnami/zookeeper:3.9.3
		ports:
			- "2181:2181"

	kafka:
		image: bitnami/kafka:3.7.0
		ports:
			- "9092:9092"
		environment:
			KAFKA_BROKER_ID: 1
			KAFKA_CFG_ZOOKEEPER_CONNECT: zookeeper:2181
			KAFKA_CFG_LISTENERS: PLAINTEXT://:9092
			KAFKA_CFG_ADVERTISED_LISTENERS: PLAINTEXT://localhost:9092
		depends_on:
			- zookeeper
  ```

### 2. 🚪 Access Kafka Container

  

To access the Kafka container and navigate to the Kafka CLI tools:

```bash
docker exec -it kafka /bin/bash

cd /opt/bitnami/kafka/bin
```
  

### 3. 🧵 Create Kafka Topic

Create a topic named test-topic using the following command:

```bash
./kafka-topics.sh --create --topic test-topic \

--bootstrap-server localhost:9092 \

--replication-factor 1 \

--partitions 1
```
  

### 4. 📤 Run Producer (Chat Sender)

Launch a Kafka producer to send messages to the topic:

```bash
./kafka-console-producer.sh --topic test-topic --bootstrap-server localhost:9092
```
  

### 5. 📥 Run Consumer (Chat Receiver in Another Terminal)

Open another terminal and start a Kafka consumer to receive messages from the topic:

```bash
./kafka-console-consumer.sh --topic test-topic \

--from-beginning --bootstrap-server localhost:9092
```
  

### 📷 Demo Preview

🖊️ Producer Terminal

```bash
> Hello Kafka!

> This is a test message.
```
  

### 📺 Consumer Terminal

```bash
Hello Kafka!

This is a test message.
```

---
<br/>

### 🧾 Commands Summary

  

All important Kafka terminal commands are included in a separate file named:

```bash
steps.txt
```
  

### 🎯 Outcome


✅ Successfully simulated real-time messaging using Apache Kafka.

✅ Gained hands-on experience with Docker-based Kafka + Zookeeper setup.

✅ Understood Kafka topic creation and producer-consumer model using CLI.