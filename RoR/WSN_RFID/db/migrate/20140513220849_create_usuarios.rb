class CreateUsuarios < ActiveRecord::Migration
  def change
    create_table :usuarios do |t|
      t.string :status
      t.string :password
      t.string :email
      t.string :nombre
      t.string :apellido

      t.timestamps
    end
  end
end
