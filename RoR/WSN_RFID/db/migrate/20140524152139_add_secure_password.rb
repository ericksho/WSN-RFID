class AddSecurePassword < ActiveRecord::Migration
  def up
  	rename_column :usuarios, :password, :password_digest
  	Usuario.reset_column_information
	  require 'bcrypt'
    Usuario.all.each do |u|
      u.password = u.password_digest
      u.password_confirmation = u.password
      u.save
    end
  end
end
