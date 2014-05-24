class Usuario < ActiveRecord::Base
	has_many :permisos, through: :permisos_usuarios
	has_many :permisos_usuarios

	has_secure_password

	validates :email, presence: true, format: { with: /\A([^@\s]+)@((?:[-a-z0-9]+\.)+[a-z]{2,})\Z/i }, uniqueness: true
	validates :password, confirmation: true, length: { in: 8..50 }
	validates :password_confirmation, presence: true

	def self.authenticate(email, password)
		Usuario.find_by(email: email).try(:authenticate, password)
	end
end

