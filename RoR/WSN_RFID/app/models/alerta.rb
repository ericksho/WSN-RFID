class Alerta < ActiveRecord::Base
	belongs_to :lectura

	def pushAlert
		client = Washbullet::Client.new('v1qn6w7zdFmFJI729Q8wiDHdY1LfGm1cVvujvycASDUzI') #hay que hacer esto modificable

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


		devices.each  do |device|
			device_iden = device["iden"]
			client.push_note(device_iden, 'Alerta', msg)
  		end
  	end
		
end
