using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Carro : MonoBehaviour
{
[SerializeField] WheelCollider RodaTraseiraDireita;
[SerializeField] WheelCollider RodaFrenteDireita;
[SerializeField] WheelCollider RodaFrenteEsquerda;
[SerializeField] WheelCollider RodaTraseiraEsquerda;
public Light LuzFreioEsquerda; // Luz de freio esquerda
public Light LuzFreioDireita;  // Luz de freio direita
public GameObject LuzEsquerda; // Farol esquerdo do carro
public GameObject LuzDireita;  // Farol direito do carro
public float aceleracao = 500f;
public float freio = 300f;
public float anguloTorque = 15f;
private float aceleracaoAtual = 0f;
private float freioAtual = 0f;
private float anguloTorqueAtual = 0f;
private void FixedUpdate()
{
aceleracaoAtual = aceleracao * Input.GetAxis("Vertical");
RodaFrenteDireita.motorTorque = aceleracaoAtual;
RodaFrenteEsquerda.motorTorque = aceleracaoAtual;
anguloTorqueAtual = anguloTorque * Input.GetAxis("Horizontal");
RodaFrenteDireita.steerAngle = anguloTorqueAtual;
RodaFrenteEsquerda.steerAngle = anguloTorqueAtual;
if (Input.GetKey(KeyCode.Space))
{
freioAtual = freio;
}
else
{
freioAtual = 0f; 
}
RodaFrenteDireita.brakeTorque = freioAtual;
RodaFrenteEsquerda.brakeTorque = freioAtual;
RodaTraseiraDireita.brakeTorque = freioAtual;
RodaTraseiraEsquerda.brakeTorque = freioAtual;


// Codigo para ligar e desligar os farois do carro apertando a tecla "E"
if (Input.GetKeyDown(KeyCode.E)) {

            if (LuzEsquerda.activeSelf) {
                LuzEsquerda.SetActive(false);
            }
            else {
                LuzEsquerda.SetActive(true);
            }
        }
if (Input.GetKeyDown(KeyCode.E)) {

            if (LuzDireita.activeSelf) {
                LuzDireita.SetActive(false);
            }
            else {
                LuzDireita.SetActive(true);
            }
        }


// Codigo para ligar a luz de freio quando freiarmos o carro
if (Input.GetKey(KeyCode.Space)) {
    LuzFreioEsquerda.intensity = 1;
    LuzFreioDireita.intensity = 1;
}
else {
    LuzFreioEsquerda.intensity = 0;
    LuzFreioDireita.intensity = 0;
}
}
}