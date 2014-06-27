class Alerta < ActiveRecord::Base
	belongs_to :lectura
	after_create { |record| record.pushAlert}

	def pushAlert
		pushbullets = Pushbullet.all
	
		pushbullets.each do |p|

			client = Washbullet::Client.new(p.token) #hay que hacer esto modificable

			devicesHash = client.devices

			devices = devicesHash.body["devices"]

			msg = 'Se generó una alerta '

			if(self.lectura.nil?)
				msg += 'de manera manual'
			else
				lectura = self.lectura
				msg += 'el ' + lectura.fecha.to_s + ' '

				if(!lectura.articulo.nil?)
					msg += 'con el rfid asociado: ' + lectura.articulo.rfid.to_s + ' '
				end

				if(!lectura.lector.nil?)
					msg += 'en el lector ' + lectura.lector.posicion.to_s + ' '
				end	
			end		

			devices.each  do |device|
				device_iden = device["iden"]
				client.push_note(device_iden, 'Alerta', msg)
	  		end
		  	
	  	end
  	end
		
end
