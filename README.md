# ProgettoLogin.Api

Lo scopo di questo nuovo progetto è sviluppare un’Api del progetto precedente. I metodi dei controller HomeControllerApi e EditControllerApi condividono la stessa logica dei metodi dei controller HomeController e EditController del sito web sviluppato precedentemente. La differenza dei controller è la risposta; mentre i metodi del progetto precedente indirizzavano a delle view, in questo pogretto i metodi, se chiamati con richieste HTTP, restituiscono solamente le informazioni. Questo progetto Api può essere utilizzato come server ma il client deve essere sviluppato separatamente. In questo progetto è stato sviluppato inoltre il controller UserControllerApi che viene utilizzato per richiedere delle informazioni generali riguardanti le informazioni salvate nel database.
Seguono un esempio di richiesta HTTP che è possibile inviare da un client e un esempio di risposta che potrebbe essere restitita dal server.

Esempio di Url per una richiesta HTTP: http://localhost:5119/EditControllerApi/addsite?idAccount=46&siteNowStr=www.test.com


HomeControllerApi

	Login: La richiesta HTTP è di tipo “POST” e richiede nel body: l’email, la password. Restituendo, se corretto e dopo aver svolto la logica, tutte le informazioni necessarie per la view Main.
EditControllerApi

	CreateAccount: La richiesta HTTP è di tipo “POST” e richiede nel body il model login e quindi l’email e la password. Restituisce, dopo aver svolto la logica, le informazioni dell’account aggiornate.

	ChangePassword: La richiesta HTTP è di tipo “PATCH” e richiede l’idAccount, la password attuale e la nuova password scritta due volte. Restituisce, dopo aver svolto la logica, le informazioni dell’account aggiornate.

	AddSite: La richiesta HTTP è di tipo “POST” e con l’”idAccount” e il sito da aggiungere. Restituisce, dopo aver svolto la logica, le informazioni dell’account aggiornate.

	DeleteSite: La richiesta HTTP è di tipo “Delete” richiedendo l’”idAccount” e il sito da togliere dall’account. Restituisce, dopo aver svolto la logica, le informazioni dell’account aggiornate.

	DeleteAccount: La richiesta HTTP è di tipo “Delete” richiedendo l’”idAccount” dell’account da eliminare. Restituisce, dopo aver svolto la logica, le informazioni dell’account aggiornate.


UserControllerApi

	Status: è utilizzato per testare la connessione e l’esecuzione del server. Se la richiesta e la risposta sono valide e il server è in esecuzione allora il server restituisce una risposta con body la stringa: “Ok”

	List: è utilizzato per restituire la lista dei account registrati nel database

	GetById: Utilizzato per restituire tutte le informazioni riguardanti uno specifico account in base all’id richiesto.

	AccountSite: Restituisce, per ogni account, tutti i siti a cui è registrato. Verrà creata una lista con n tupla (è una raccolta di oggetti di diversi tipi) dove n è il numero di account registrati.Per ogni tupla verrà dichiarato l’email dell’account e una lista con tutti i siti a cui quel account è registrato.

	TopSavedSites: Restituisce in ordine decrescente i siti più registarti dagli account e la percentuale nel totale. Nella richiesta dovrà esser presente il numero dei migliori siti che verrà visualizzato.

	WheneNewAccount: Restituisce tutte le informazioni per creare il grafico con chart.js, come nel metodo DrawTimeXSitesGraphic nel progetto del sito web. Nella richiesta dovrà esser presente il numero dei giorni che si vuole rappresentare.


Testing

Il testing dell’Api è stato svolto con l’utilizzo del software “Postman” che è stato descritto precedentemente. È stato deciso di testare l’Api in modo veloce e continuativo, è stato quindi scetlto di utilizzare un “Runner”. Il runner permette di automatizzare il processo di testing inviando diverse richieste HTTP al server in modo sequenziale e automatico, restituendo i risultati in modo conoscere le richieste che non sono andate a buon fine. Per semplificare e automatizzare il processo sono state utilizzate variabili d’ambiente e variabili globali che possono essere assegnate con valori random. Postman inoltre, permette di aggiungere del codice in Javascript per rendere possibile la sequenza di test, settando le variabili globali con le risposte HTTP che vengono ricevute dal server. 

Segue un esempio di Body in formato raw che crea una stringa random che raffigura un’email. La password invece viene sempre assegnata come “prova1234”. 

![image](https://user-images.githubusercontent.com/109733062/233656916-ead5310d-c519-4432-be61-4dd47050c3da.png)

Segue un esempio di codice javascript utilizzato nel test della richiesta POST “Create Account”. Nella prima parte del codice viene testata la risposta del server, infatti se lo status della risposta è 201 allora il test verrà considera andato a buon fine. La risposta viene salvata in una costante “response” e successivamente verranno assegnate le variabili globali “idAccountTest” e “emailTest” che verranno utilizzate successivamente in un altro test di richiesta HTTP.

![image](https://user-images.githubusercontent.com/109733062/233656731-3189cd9f-e1e7-4103-8145-e655015cc130.png)

Seguono due immagini che mostrano che un test runner è stato eseguito in modo corretto, senza restituire degli errori. In queste due immagini vengono mostrati gli Url di richiesta, lo status di risposta dal server e se il test è passed o è fallito.
 
 ![image](https://user-images.githubusercontent.com/109733062/233656546-019f50e2-f959-4c4e-ad41-9461ab6c134e.png)
